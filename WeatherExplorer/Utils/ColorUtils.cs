using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Utils
{
    public static class ColorUtils
    {
        public static Color MakeDarker(Color color, double ratio)
        {
            int r = (int)(color.R * ratio);
            int g = (int)(color.G * ratio);
            int b = (int)(color.B * ratio);
            return Color.FromArgb(r, g, b);
        }

        public static bool IsDarkColor(Color color)
        {
            return (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) < 128;
        }

        public static Color GetForeground(Color background)
        {
            return IsDarkColor(background) ? Color.White : Color.Black;
        }
    }
}
