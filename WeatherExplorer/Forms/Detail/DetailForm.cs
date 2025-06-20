using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using WeatherExplorer.Resource.Managers.WeatherSnapshot;

namespace WeatherExplorer.Forms.Detail
{
    public partial class DetailForm : Form
    {
        private WeatherData Data { get; }

        public DetailForm(Snapshot snapshot)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Data = snapshot.Data;
            InitializeContent();
        }

        private void InitializeContent()
        {
            dgvInfo.Rows.Add("天气状态", Data.Text);
            dgvInfo.Rows.Add("气温", $"{Data.Temp}℃");
            dgvInfo.Rows.Add("体感温度(原始)", $"{Data.FeelsLike}℃");
            dgvInfo.Rows.Add("体感温度(改进)", $"{Data.ImprovedFeelsLike.ToString("0.###")}℃");
            dgvInfo.Rows.Add("相对湿度", $"{Data.Rh}%");
            dgvInfo.Rows.Add("露点温度", $"{Data.Dew}℃");
            dgvInfo.Rows.Add("风速", $"{Data.WindSpeed}m/s");
            dgvInfo.Rows.Add("蒲福风级", Data.WindClass);
            dgvInfo.Rows.Add("风向(角度)", $"{Data.WindAngle}°");
            dgvInfo.Rows.Add("风向(方位)", Data.WindDir);
            dgvInfo.Rows.Add("降雨量", $"{Data.Prec}mm");
            dgvInfo.Rows.Add("降雨更新", $"{DateTime.Parse(Data.PrecTime):HH:mm}");
            dgvInfo.Rows.Add("云量", $"{Data.Clouds}%");
            dgvInfo.Rows.Add("能见度", $"{Data.Vis}m");
            dgvInfo.Rows.Add("气压", $"{Data.Pressure}hPa");
            dgvInfo.Rows.Add("紫外线指数", Data.Uv);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
