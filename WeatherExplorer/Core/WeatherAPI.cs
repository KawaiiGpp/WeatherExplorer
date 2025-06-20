using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherExplorer.Core
{
    public class WeatherAPI : IDisposable
    {
        private bool disposed = false;

        private string Token { get; set; }
        private string Url { get; set; }
        private HttpClient Client { get; set; }

        public bool AlreadyDisposed => disposed;

        public WeatherAPI()
        {
            Token = Environment.GetEnvironmentVariable("WEATHER_TOKEN")??
                throw new ArgumentNullException("Token not found from environment variable.");
            Url = Environment.GetEnvironmentVariable("WEATHER_API")??
                throw new ArgumentNullException("Url not found from environment variable.");
            
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("X-APISpace-Token", Token);
        }

        public async Task<WeatherResponse> Get(string cityId)
        {
            if (disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            try
            {
                using (HttpResponseMessage response = await Client.GetAsync($"{Url}{cityId}"))
                {
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();
                    return new WeatherResponse("操作成功", result, false);
                }
            }
            catch (HttpRequestException ex)
            {
                return new WeatherResponse("请求错误", ex.Message, true);
            }
            catch (Exception ex)
            {
                return new WeatherResponse("未知错误", ex.Message, true);
            }
        }

        public void Dispose()
        {
            if (disposed) return;

            Client.Dispose();
            disposed = true;
        }
    }
}
