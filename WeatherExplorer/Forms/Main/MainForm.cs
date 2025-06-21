using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherExplorer.Core;
using WeatherExplorer.Forms.Alarm;
using WeatherExplorer.Forms.CityPicker;
using WeatherExplorer.Forms.Detail;
using WeatherExplorer.Resource.Managers;
using WeatherExplorer.Resource.Managers.CityMap;
using WeatherExplorer.Resource.Managers.WeatherSnapshot;
using WeatherExplorer.Utils;

namespace WeatherExplorer.Forms.Main
{
    public partial class MainForm : Form
    {
        private string OriginalTitle { get; set; }
        private WeatherAPI Api { get; set; }
        private bool Debugging { get; set; } = false;
        private string SelectedCityId { get; set; }
        private Snapshot Cache { get; set; }

        public MainForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            OriginalTitle = Text;
            try
            {
                Api = new WeatherAPI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"致命错误：初始化异常\n{ex.Message}", "错误");
            }
        }

        private async Task LoadWeatherSnapshot()
        {
            if (Debugging)
            {
                LoadWeatherSnapshot(GetSnapshotDemo());
                return;
            }

            WeatherResponse response = await Api.Get(SelectedCityId);
            if (response.Error)
            {
                MessageBox.Show($"{response.Title}\n{response.Content}", "错误");
                return;
            }

            LoadWeatherSnapshot(response.Content);
        }

        private async void btnCityPicker_Click(object sender, EventArgs e)
        {
            try
            {
                CityPickerForm.Show(out Province province, out City city, out District district);
                if (district == null) return;

                SelectedCityId = district.Id;
                await LoadWeatherSnapshot();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"城市选择按钮事件处理异常\n请联系开发者\n{ex.Message}", "错误");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedCityId != null) await LoadWeatherSnapshot();
                else MessageBox.Show("选择城市之后才能进行刷新。", "错误");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刷新按钮事件处理异常\n请联系开发者\n{ex.Message}", "错误");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OpenIfCacheLoaded(() => new DetailForm(Cache));
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            OpenIfCacheLoaded(() => new AlarmForm(Cache));
        }

        private void LoadWeatherSnapshot(string raw)
        {
            Snapshot snapshot = new Snapshot(raw);
            Cache = snapshot;
            Text = $"{OriginalTitle} - {snapshot.Location} - 更新时间 {snapshot.UpdateTime:yyyy/MM/dd HH:mm}";

            WeatherData data = snapshot.Data;
            LoadFeelTemperature(data.ImprovedFeelsLike);
            LoadTemperature(data.Temp);
            LoadHumidity(data.Rh);
            LoadWindSpeed(data.WindSpeed);

            LoadTemperatureDesc(data.Temp, data.ImprovedFeelsLike);
            LoadWindSpeedDesc(data.WindClass, data.WindAngle);
            LoadHumidityDesc(data.Rh);
        }

        private string GetSnapshotDemo()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string url = "WeatherExplorer.Resource.Files.weather_snapshot_demo.json";

            using (Stream stream = assembly.GetManifestResourceStream(url))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private void LoadFeelTemperature(double value)
        {
            lblFeel.Text = value.ToString("0.##");
            lblFeel.BackColor = ColorRange.Temperature.GetMatchedColor(value);
            lblFeel.ForeColor = ColorUtils.GetForeground(lblFeel.BackColor);
        }

        private void LoadTemperature(double value)
        {
            lblTemp.Text = $"{value}℃";
            lblTemp.BackColor = ColorRange.Temperature.GetMatchedColor(value);
            lblTemp.ForeColor = ColorUtils.GetForeground(lblTemp.BackColor);
        }

        private void LoadHumidity(int value)
        {
            lblRh.Text = $"{value}% RH";
            lblRh.BackColor = ColorRange.Humidity.GetMatchedColor(value);
            lblRh.ForeColor = ColorUtils.GetForeground(lblRh.BackColor);
        }

        private void LoadWindSpeed(double value)
        {
            lblWind.Text = $"{value}m/s";
            lblWind.BackColor = ColorRange.WindSpeed.GetMatchedColor(value);
            lblWind.ForeColor = ColorUtils.GetForeground(lblWind.BackColor);
        }

        private void LoadTemperatureDesc(double temp, double feel)
        {
            string desc;
            double difference = feel - temp;
            char cold, hot;

            if (temp >= 20)
            {
                cold = '凉';
                hot = '闷';
            }
            else
            {
                cold = '冷';
                hot = '暖';
            }

            if (difference <= -6) desc = $"体感比实际{cold}得多";
            else if (difference <= -3) desc = $"体感明显更{cold}";
            else if (difference <= -1) desc = $"体感稍{cold}一些";
            else if (difference <= 1) desc = $"体感和实际相近";
            else if (difference <= 3) desc = $"体感稍{hot}一些";
            else if (difference <= 6) desc = $"体感明显更{hot}";
            else desc = $"体感比实际{hot}得多";

            lblTempDesc.Text = desc;
        }

        private void LoadWindSpeedDesc(string level, int angle)
        {
            lblWindDesc.Text = $"{WeatherUtils.GetWindDirection(angle)} 约{level}";
        }

        private void LoadHumidityDesc(int value)
        {
            lblRhDesc.Text = $"体感{WeatherUtils.GetHumidityDesc(value)}";
        }

        private void OpenIfCacheLoaded(Func<Form> func)
        {
            if (Cache != null) func.Invoke().ShowDialog();
            else MessageBox.Show("请先选择城市，获取对应天气信息再试。", "错误");
        }
    }
}
