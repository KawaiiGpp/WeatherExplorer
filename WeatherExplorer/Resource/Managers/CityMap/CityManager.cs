using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherExplorer.Resource.Managers.CityMap
{
    public class CityManager
    {
        private static readonly CityManager instance = new CityManager();
        public static CityManager Instance => instance;

        private List<Province> Provinces { get; }

        private CityManager()
        {
            Provinces = new List<Province>();
            InitializeCityMap();
        }

        public Province GetProvince(string name)
        {
            return Provinces.FirstOrDefault(p => name.Equals(p.Name));
        }

        public void RegisterProvince(Province province)
        {
            if (GetProvince(province.Name) == null)
            {
                Provinces.Add(province);
            }
            else
            {
                throw new ArgumentException($"Province already exists: {province.Name}");
            }
        }

        public List<Province> GetProvincesCopied()
        {
            return new List<Province>(Provinces);
        }

        private void InitializeCityMap()
        {
            using (StreamReader reader = CreateReader())
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] args = line.Split('=');

                    string id = args[0];
                    string provinceName = args[1];
                    string cityName = args[2];
                    string districtName = args[3];

                    Province province = GetProvince(provinceName);
                    if (province == null)
                    {
                        province = new Province(provinceName);
                        RegisterProvince(province);
                    }

                    City city = province.GetCity(cityName);
                    if (city == null)
                    {
                        city = new City(cityName);
                        province.RegisterCity(city);
                    }

                    city.RegisterDistrict(new District(districtName, id));
                }
            }
        }

        private StreamReader CreateReader()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string url = "WeatherExplorer.Resource.Files.city_id_map.txt";
            return new StreamReader(assembly.GetManifestResourceStream(url), Encoding.UTF8);
        }
    }
}
