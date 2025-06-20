using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExplorer.Core
{
    public class WeatherResponse
    {
        public string Title { get; }
        public string Content { get; }
        public bool Error { get; }

        public WeatherResponse(string title, string content, bool error)
        {
            Title = title;
            Content = content;
            Error = error;
        }
    }
}
