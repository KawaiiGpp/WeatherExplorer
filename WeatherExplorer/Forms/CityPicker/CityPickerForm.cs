using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherExplorer.Resource.Managers.CityMap;

namespace WeatherExplorer.Forms.CityPicker
{
    public partial class CityPickerForm : Form
    {
        public Province ProvinceSelected { get; private set; }
        public City CitySelected { get; private set; }
        public District DistrictSelected { get; private set; }

        private CityPickerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            cbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;

            ResetComboxes();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbProvince.Text.Length > 0 && cbCity.Text.Length > 0 && cbDistrict.Text.Length > 0)
            {
                CityManager manager = CityManager.Instance;
                ProvinceSelected = manager.GetProvince(cbProvince.Text);
                CitySelected = ProvinceSelected.GetCity(cbCity.Text);
                DistrictSelected = CitySelected.GetDistrict(cbDistrict.Text);
                Close();
            }
            else
            {
                MessageBox.Show("请正确填写位置信息。", "错误");
            }
        }

        private void ResetComboxes()
        {
            cbProvince.Items.Clear();
            cbCity.Items.Clear();
            cbDistrict.Items.Clear();

            cbProvince.Enabled = true;
            cbCity.Enabled = false;
            cbDistrict.Enabled = false;

            cbProvince.Select();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetComboxes();
        }

        private void cbProvince_DropDown(object sender, EventArgs e)
        {
            if (cbProvince.Items.Count > 0) return;

            List<Province> provinces = CityManager.Instance.GetProvincesCopied();
            provinces.ForEach(p => cbProvince.Items.Add(p.Name));
        }

        private void cbCity_DropDown(object sender, EventArgs e)
        {
            if (cbCity.Items.Count > 0) return;

            List<City> cities = CityManager.Instance.GetProvince(cbProvince.Text).GetCitiesCopied();
            cities.ForEach(c => cbCity.Items.Add(c.Name));
        }

        private void cbDistrict_DropDown(object sender, EventArgs e)
        {
            if (cbDistrict.Items.Count > 0) return;

            City city = CityManager.Instance.GetProvince(cbProvince.Text).GetCity(cbCity.Text);
            city.GetDistrictsCopied().ForEach(d => cbDistrict.Items.Add(d.Name));
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProvince.Enabled = false;
            cbCity.Enabled = true;

            cbCity.Select();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.Enabled = false;
            cbDistrict.Enabled = true;

            cbDistrict.Select();
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrict.Enabled = false;

            btnConfirm.Select();
        }

        public static void Show(out Province province, out City city, out District district)
        {
            CityPickerForm form = new CityPickerForm();
            form.ShowDialog();

            province = form.ProvinceSelected;
            city = form.CitySelected;
            district = form.DistrictSelected;
        }
    }
}
