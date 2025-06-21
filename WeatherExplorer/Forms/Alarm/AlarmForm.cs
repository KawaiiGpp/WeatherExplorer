using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherExplorer.Resource.Managers.Alarms;
using WeatherExplorer.Resource.Managers.WeatherSnapshot;

namespace WeatherExplorer.Forms.Alarm
{
    public partial class AlarmForm : Form
    {
        private WeatherData Data { get; set; }

        public AlarmForm(Snapshot snapshot)
        {
            InitializeComponent();
            Data = snapshot.Data;
            StartPosition = FormStartPosition.CenterParent;

            InitializeAlarmList();
        }

        private void InitializeAlarmList()
        {
            List<AlarmItem> list = AlarmItem.GetAlarms(Data.ImprovedFeelsLike, Data.WindSpeed);
            if (list.Count == 0) lvAlarmList.Items.Add("目前气温和湿度让人体感适中，风力未达阈值，故暂无信息。");

            list.ForEach(alarm =>
            {
                int index = imglAlarmList.Images.Count;
                ListViewItem item = new ListViewItem($"【{alarm.DisplayName}】{alarm.Description}", index);
                imglAlarmList.Images.Add(alarm.ToImage());
                lvAlarmList.Items.Add(item);
            });
        }
    }
}
