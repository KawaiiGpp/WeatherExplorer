using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Resource.Managers.CityMap
{
    public class Province
    {
        private List<City> Cities { get; }
        public string Name { get; }

        public Province(string name)
        {
            Name = name;
            Cities = new List<City>();
        }

        public void RegisterCity(City city)
        {
            if (GetCity(city.Name) == null)
            {
                Cities.Add(city);
            }
            else
            {
                throw new ArgumentException($"City already exists: {city.Name}");
            }
        }

        public List<City> GetCitiesCopied()
        {
            return new List<City>(Cities);
        }

        public City GetCity(string name)
        {
            return Cities.FirstOrDefault(c => name.Equals(c.Name));
        }
    }
}
