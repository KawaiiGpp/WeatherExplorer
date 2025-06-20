using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherExplorer.Utils;

namespace WeatherExplorer.Core
{
    public class FeelCalculator
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public bool IsTropical => Pressure < 980 && Humidity > 70 && Temperature > 15;

        public FeelCalculator(double temp, double wind, double humidity, double pressure)
        {
            Temperature = temp;
            WindSpeed = wind;
            Humidity = humidity;
            Pressure = pressure;
        }

        public double Calculate()
        {
            if (WindSpeed < 0) throw new ArgumentException("Wind speed cannot be lower than 0.");
            if (Humidity < 0 || Humidity > 100) throw new ArgumentException("Humidity must be from 0 to 100.");

            if (WindSpeed > 20) return HandleExtremeWind();

            if (Temperature <= 10 && WindSpeed >= 1.34) return CalculateWindChill();
            else if (Temperature >= 27) return CalculateHeatIndex();
            else return CalculateApparentTemperature();
        }

        private double CalculateWindChill()
        {
            // 风寒计算
            double windKmh = WindSpeed * 3.6;
            return 13.12 +
                   0.6215 * Temperature -
                   11.37 * Math.Pow(windKmh, 0.16) +
                   0.3965 * Temperature * Math.Pow(windKmh, 0.16);
        }

        private double CalculateHeatIndex()
        {
            // 热指数计算

            // Rothfusz回归方程
            double c1 = -8.78469475556;
            double c2 = 1.61139411;
            double c3 = 2.33854883889;
            double c4 = -0.14611605;
            double c5 = -0.012308094;
            double c6 = -0.0164248277778;
            double c7 = 0.002211732;
            double c8 = 0.00072546;
            double c9 = -0.000003582;

            return c1 + c2 * Temperature + c3 * Humidity + c4 * Temperature * Humidity +
                   c5 * Math.Pow(Temperature, 2) + c6 * Math.Pow(Humidity, 2) +
                   c7 * Math.Pow(Temperature, 2) * Humidity +
                   c8 * Temperature * Math.Pow(Humidity, 2) +
                   c9 * Math.Pow(Temperature, 2) * Math.Pow(Humidity, 2);
        }

        private double CalculateApparentTemperature()
        {
            // 表观温度计算

            // 计算水汽压（hPa）
            double saturationVaporPressure = 6.105 * Math.Exp((17.27 * Temperature) / (237.7 + Temperature));
            double vaporPressure = saturationVaporPressure * (Humidity / 100.0);

            // 有效风速上限10m/s
            double effectiveWind = Math.Min(WindSpeed, 10);

            return Temperature + 0.348 * vaporPressure - 0.70 * effectiveWind - 4.25;
        }

        private double HandleExtremeWind()
        {
            /* 决策树：
               1. 热带系统（台风/飓风）-> 台风模型
               2. 低温环境（<5℃）-> 增强风寒模型
               3. 中温环境（5-20℃）-> 混合模型
               4. 高温环境（>20℃）-> 台风模型 */

            if (IsTropical || Temperature > 20) return CalculateTyphoonEffect();
            else if (Temperature < 5) return CalculateEnhancedWindChill();
            else return CalculateTemperateCycloneEffect();
        }


        private double CalculateTyphoonEffect()
        {
            // 台风效应模型

            /* 台风效应三阶段模型：
               1. 基础冷却：风速×0.5（最大15℃）
               2. 湿度补偿：高湿削弱冷却效果
               3. 热带衰减：温度越高冷却效果越弱 */

            double baseCooling = Math.Min(WindSpeed * 0.5, 15);
            double humidityFactor = 0.6 + 0.4 * (1 - Humidity / 100);
            double tropicalFactor = 1 - Math.Exp(-Math.Max(0, 27 - Temperature) / 5);

            double feelsLike = Temperature - baseCooling * humidityFactor * tropicalFactor;

            // 热力学边界约束
            return Math.Max(Temperature - 15, Math.Min(feelsLike, Temperature + 5));
        }
        
        private double CalculateEnhancedWindChill()
        {
            // 增强型风寒模型

            // 基础风寒计算
            double baseWC = CalculateWindChill();

            // 高风速修正（20m/s以上每m/s额外降温0.2℃）
            if (WindSpeed > 20)
            {
                double extraCooling = (WindSpeed - 20) * 0.2;
                double result = baseWC - Math.Min(extraCooling, 5);

                // 极寒边界保护（不低于-60℃）
                return Math.Max(result, -60);
            }
            return baseWC;
        }

        private double CalculateTemperateCycloneEffect()
        {
            // 温带气旋效应模型

            // 计算基础值
            double wc = CalculateWindChill();
            double hi = CalculateHeatIndex();

            // 动态权重（基于温度）
            double windChillWeight = MathUtils.Clamp((15 - Temperature) / 15, 0.2, 0.8);

            // 湿度影响因子（0.8-1.2）
            double humidityFactor = 0.8 + (Humidity / 100) * 0.4;

            double result = (windChillWeight * wc) + ((1 - windChillWeight) * hi) * humidityFactor;

            // 边界保护
            return Math.Max(Temperature - 10, Math.Min(result, Temperature + 10));
        }
    }
}
