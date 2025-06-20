using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherExplorer.Utils;

namespace WeatherExplorer.Core
{
    public class ColorRange
    {
        public List<(double temp, Color color)> Stops { get; }

        public ColorRange(List<(double temp, Color color)> stops)
        {
            Stops = stops;
        }

        public Color GetMatchedColor(double temp)
        {
            int lastIndex = Stops.Count - 1;

            if (temp <= Stops[0].temp) return Stops[0].color;
            if (temp >= Stops[lastIndex].temp) return Stops[lastIndex].color;

            for (int i = 0; i < Stops.Count - 1; i++)
            {
                (double t1, Color c1) = Stops[i];
                (double t2, Color c2) = Stops[i + 1];

                if (temp >= t1 && temp < t2)
                {
                    float ratio = (float)((temp - t1) / (t2 - t1));
                    return Combine(c1, c2, ratio);
                }
            }

            return Color.Magenta;
        }

        private Color Combine(Color c1, Color c2, float ratio)
        {
            if (ratio >= 1) return c2;
            if (ratio <= 0) return c1;

            int r = (int)Math.Round(c1.R * (1 - ratio) + c2.R * ratio);
            int g = (int)Math.Round(c1.G * (1 - ratio) + c2.G * ratio);
            int b = (int)Math.Round(c1.B * (1 - ratio) + c2.B * ratio);

            return Color.FromArgb(r, g, b);
        }

        public static readonly ColorRange Temperature = new ColorRange(new List<(double temp, Color color)>
        {
            (-40, Color.Purple),
            (0, Color.Blue),
            (15, Color.Cyan),
            (20, Color.LimeGreen),
            (28, Color.Gold),
            (34, Color.Red),
            (50, Color.Black)
        });
        public static readonly ColorRange Humidity = new ColorRange(new List<(double temp, Color color)>
        {
            (0, Color.OrangeRed),
            (35, Color.Gold),
            (55, Color.LimeGreen),
            (70, ColorUtils.MakeDarker(Color.Cyan, 0.9)),
            (90, Color.Blue),
            (100, Color.Purple)
        });
        public static readonly ColorRange WindSpeed = new ColorRange(new List<(double temp, Color color)>
        {
            (0.0, ColorUtils.MakeDarker(Color.Cyan, 0.9)),
            (3.4, Color.LimeGreen),
            (10.8, Color.Gold),
            (24.5, Color.Red),
            (41.5, Color.Black)
        });
    }
}
