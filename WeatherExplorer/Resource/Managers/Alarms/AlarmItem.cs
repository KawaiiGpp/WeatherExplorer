using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherExplorer.Resource.Managers.Alarms
{
    public class AlarmItem
    {
        private static readonly string urlPrefix = "WeatherExplorer.Resource.Files.Alarms.";

        public string FileName { get; }
        public string DisplayName { get;  }
        public string Description { get; }

        public AlarmItem(string fileName, string displayName, string desc)
        {
            FileName = fileName;
            DisplayName = displayName;
            Description = desc;
        }

        public Image ToImage()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream($"{urlPrefix}{FileName}"))
            {
                if (stream != null) return Image.FromStream(stream);
                throw new FileNotFoundException($"Resource {FileName} not found in assembly.");
            }
        }

        public static readonly AlarmItem HeatIV = new AlarmItem("heat_iv.png", "高温IV级",
            "体感温度达32℃以上，天气炎热，请注意防晒补水。");
        public static readonly AlarmItem HeatIII = new AlarmItem("heat_iii.png", "高温III级",
            "体感温度达36℃以上，天气炎热，请注意防暑降温。");
        public static readonly AlarmItem HeatII = new AlarmItem("heat_ii.png", "高温II级",
            "体感温度达40℃以上，天气酷热，高温时段请减少户外活动。"); 
        public static readonly AlarmItem HeatI = new AlarmItem("heat_i.png", "高温I级",
            "体感温度达45℃以上，天气酷热，请尽量避免户外活动。");

        public static readonly AlarmItem ColdIV = new AlarmItem("cold_iv.png", "寒冷IV级",
            "体感温度降至10℃以下，天气寒凉，请注意适当添衣。");
        public static readonly AlarmItem ColdIII = new AlarmItem("cold_iii.png", "寒冷III级",
            "体感温度降至5℃以下，天气寒冷，请注意防风保暖。");
        public static readonly AlarmItem ColdII = new AlarmItem("cold_ii.png", "寒冷II级",
            "体感温度降至-2℃以下，天气寒冷，请减少长时间停留户外。");
        public static readonly AlarmItem ColdI = new AlarmItem("cold_i.png", "寒冷I级",
            "体感温度降至-7℃以下，天气严寒，请避免长时间停留户外。");

        public static readonly AlarmItem GaleIV = new AlarmItem("gale_iv.png", "大风IV级",
            "当前风力已达5级以上，请注意防风，打伞行走可能困难。");
        public static readonly AlarmItem GaleIII = new AlarmItem("gale_iii.png", "大风III级", 
            "当前风力已达6~7级，请注意防风，打伞行走危险。");
        public static readonly AlarmItem GaleII = new AlarmItem("gale_ii.png", "大风II级",
            "当前风力已达8~9级，请避免外出，当心高空坠物。");
        public static readonly AlarmItem GaleI = new AlarmItem("gale_i.png", "大风I级",
            "当前风力已达10~11级或以上，风力减弱前请勿外出。");

        public static List<AlarmItem> GetAlarms(double feelTemperature, double windSpeed)
        {
            List<AlarmItem> result = new List<AlarmItem>();

            if (feelTemperature <= -7) result.Add(ColdI);
            else if (feelTemperature <= -2) result.Add(ColdII);
            else if (feelTemperature <= 5) result.Add(ColdIII);
            else if (feelTemperature <= 10) result.Add(ColdIV);

            if (feelTemperature >= 45) result.Add(HeatI);
            else if (feelTemperature >= 40) result.Add(HeatII);
            else if (feelTemperature >= 36) result.Add(HeatIII);
            else if (feelTemperature >= 32) result.Add(HeatIV);

            if (windSpeed >= 24.5) result.Add(GaleI);
            else if (windSpeed >= 17.2) result.Add(GaleII);
            else if (windSpeed >= 10.8) result.Add(GaleIII);
            else if (windSpeed >= 7.5) result.Add(GaleIV);

            return result;
        }
    }
}
