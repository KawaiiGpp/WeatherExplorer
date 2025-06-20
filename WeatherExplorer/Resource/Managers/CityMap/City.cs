using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Resource.Managers.CityMap
{
    public class City
    {
        private List<District> Districts { get; }
        public string Name { get; }

        public City(string name)
        {
            Name = name;
            Districts = new List<District>();
        }

        public void RegisterDistrict(District district)
        {
            if (GetDistrict(district.Name) == null)
            {
                Districts.Add(district);
            }
            else
            {
                throw new ArgumentException($"District already exists: {district.Name}");
            }
        }

        public List<District> GetDistrictsCopied()
        {
            return new List<District>(Districts);
        }

        public District GetDistrict(string name)
        {
            return Districts.FirstOrDefault(d => name.Equals(d.Name));
        }
    }
}
