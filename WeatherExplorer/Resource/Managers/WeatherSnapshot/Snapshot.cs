using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherExplorer.Resource.Managers.WeatherSnapshot
{
    public class Snapshot
    {
        public string Raw { get; }
        public WeatherData Data { get; }
        public DateTime UpdateTime { get; }
        public string Location { get; }

        public Snapshot(string raw)
        {
            Raw = raw;

            JToken token = JObject.Parse(raw)["result"];
            Data = token["realtime"].ToObject<WeatherData>();
            Location = token["location"]["name"].Value<string>();

            string updateTimeRaw = token["last_update"].Value<string>();
            UpdateTime = DateTime.Parse(updateTimeRaw);
        }
    }
}
