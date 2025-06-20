using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Resource.Managers.CityMap
{
    public class District
    {
        public string Name { get; }
        public string Id { get; }

        public District(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}
