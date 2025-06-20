namespace WeatherExplorer.Forms.CityPicker
{
    partial class CityPickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProvince
            // 
            this.cbProvince.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.IntegralHeight = false;
            this.cbProvince.Location = new System.Drawing.Point(104, 30);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(174, 33);
            this.cbProvince.TabIndex = 0;
            this.cbProvince.DropDown += new System.EventHandler(this.cbProvince_DropDown);
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.IntegralHeight = false;
            this.cbCity.Location = new System.Drawing.Point(104, 71);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(174, 33);
            this.cbCity.TabIndex = 1;
            this.cbCity.DropDown += new System.EventHandler(this.cbCity_DropDown);
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbDistrict
            // 
            this.cbDistrict.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.IntegralHeight = false;
            this.cbDistrict.Location = new System.Drawing.Point(104, 110);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(174, 33);
            this.cbDistrict.TabIndex = 2;
            this.cbDistrict.DropDown += new System.EventHandler(this.cbDistrict_DropDown);
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            // 
            // lblProvince
            // 
            this.lblProvince.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProvince.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblProvince.Location = new System.Drawing.Point(17, 26);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(81, 38);
            this.lblProvince.TabIndex = 3;
            this.lblProvince.Text = "省";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCity.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCity.Location = new System.Drawing.Point(17, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(81, 38);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "市";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistrict
            // 
            this.lblDistrict.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDistrict.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDistrict.Location = new System.Drawing.Point(17, 107);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(81, 38);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "区";
            this.lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(43, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(235, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "重置已选项";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(43, 159);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(235, 39);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "确认位置";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CityPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 274);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.cbDistrict);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbProvince);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityPickerForm";
            this.Text = "请选择查询地点";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
    }
}