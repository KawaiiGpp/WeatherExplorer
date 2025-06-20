using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Utils
{
    public static class WeatherUtils
    {
        public static string GetHumidityDesc(int rh)
        {
            if (rh >= 90) return "非常潮湿";
            else if (rh >= 80) return "潮湿";
            else if (rh >= 60) return "较潮湿";
            else if (rh >= 50) return "舒适";
            else if (rh >= 40) return "较干燥";
            else if (rh >= 30) return "干燥";
            else return "非常干燥";
        }

        public static string GetWindDirection(int angle)
        {
            string[] directions = new string[]
            {
                "北风", "北东北风", "东北风", "东东北风",
                "东风", "东东南风", "东南风", "南东南风",
                "南风", "南西南风", "西南风", "西西南风",
                "西风", "西西北风", "西北风", "北西北风"
            };

            int index = (int)Math.Round(angle / 22.5) % 16;
            return directions[index];
        }
    }
}
