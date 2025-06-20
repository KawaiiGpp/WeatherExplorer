using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WeatherExplorer.Core;

namespace WeatherExplorer.Resource.Managers.WeatherSnapshot
{
    public class WeatherData
    {
        [JsonProperty("text")]
        public string Text { get; }

        [JsonProperty("code")]
        public string Code { get; }

        [JsonProperty("temp")]
        public double Temp { get; }

        [JsonProperty("feels_like")]
        public int FeelsLike { get; }

        [JsonProperty("rh")]
        public int Rh { get; }

        [JsonProperty("wind_class")]
        public string WindClass { get; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; }

        [JsonProperty("wind_angle")]
        public int WindAngle { get; }

        [JsonProperty("prec")]
        public double Prec { get; }

        [JsonProperty("prec_time")]
        public string PrecTime { get; }

        [JsonProperty("clouds")]
        public int Clouds { get; }

        [JsonProperty("vis")]
        public int Vis { get; }

        [JsonProperty("pressure")]
        public int Pressure { get; }

        [JsonProperty("dew")]
        public int Dew { get; }

        [JsonProperty("uv")]
        public int Uv { get; }

        [JsonProperty("snow")]
        public double Snow { get; }

        [JsonProperty("weight")]
        public int Weight { get; }

        [JsonProperty("brief")]
        public string Brief { get; }

        [JsonProperty("detail")]
        public string Detail { get; }

        [JsonConstructor]
        public WeatherData(string text, string code, double temp, int feels_like, int rh,
            string wind_class, double wind_speed, string wind_dir, int wind_angle,
            double prec, string prec_time, int clouds, int vis, int pressure,
            int dew, int uv, double snow, int weight, string brief, string detail)
        {
            Text = text;
            Code = code;
            Temp = temp;
            FeelsLike = feels_like;
            Rh = rh;
            WindClass = wind_class;
            WindSpeed = wind_speed;
            WindDir = wind_dir;
            WindAngle = wind_angle;
            Prec = prec;
            PrecTime = prec_time;
            Clouds = clouds;
            Vis = vis;
            Pressure = pressure;
            Dew = dew;
            Uv = uv;
            Snow = snow;
            Weight = weight;
            Brief = brief;
            Detail = detail;
        }

        public double ImprovedFeelsLike => new FeelCalculator(Temp, WindSpeed, Rh, Pressure).Calculate();
    }
}
