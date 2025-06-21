namespace WeatherExplorer.Forms.Main
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFeel = new System.Windows.Forms.Label();
            this.lblRh = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblRhDesc = new System.Windows.Forms.Label();
            this.lblTempDesc = new System.Windows.Forms.Label();
            this.lblWindDesc = new System.Windows.Forms.Label();
            this.btnCityPicker = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeel
            // 
            this.lblFeel.BackColor = System.Drawing.Color.White;
            this.lblFeel.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFeel.Location = new System.Drawing.Point(12, 14);
            this.lblFeel.Name = "lblFeel";
            this.lblFeel.Size = new System.Drawing.Size(516, 123);
            this.lblFeel.TabIndex = 0;
            this.lblFeel.Text = "--";
            this.lblFeel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRh
            // 
            this.lblRh.BackColor = System.Drawing.Color.White;
            this.lblRh.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRh.Location = new System.Drawing.Point(12, 199);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(167, 84);
            this.lblRh.TabIndex = 1;
            this.lblRh.Text = "--% RH";
            this.lblRh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWind
            // 
            this.lblWind.BackColor = System.Drawing.Color.White;
            this.lblWind.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.Location = new System.Drawing.Point(361, 199);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(167, 84);
            this.lblWind.TabIndex = 2;
            this.lblWind.Text = "--m/s";
            this.lblWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.White;
            this.lblTemp.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(187, 199);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(167, 84);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "--℃";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRhDesc
            // 
            this.lblRhDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblRhDesc.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRhDesc.Location = new System.Drawing.Point(12, 154);
            this.lblRhDesc.Name = "lblRhDesc";
            this.lblRhDesc.Size = new System.Drawing.Size(167, 44);
            this.lblRhDesc.TabIndex = 4;
            this.lblRhDesc.Text = "--";
            this.lblRhDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempDesc
            // 
            this.lblTempDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblTempDesc.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTempDesc.Location = new System.Drawing.Point(187, 154);
            this.lblTempDesc.Name = "lblTempDesc";
            this.lblTempDesc.Size = new System.Drawing.Size(167, 44);
            this.lblTempDesc.TabIndex = 5;
            this.lblTempDesc.Text = "--";
            this.lblTempDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWindDesc
            // 
            this.lblWindDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblWindDesc.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWindDesc.Location = new System.Drawing.Point(361, 154);
            this.lblWindDesc.Name = "lblWindDesc";
            this.lblWindDesc.Size = new System.Drawing.Size(167, 44);
            this.lblWindDesc.TabIndex = 6;
            this.lblWindDesc.Text = "--";
            this.lblWindDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCityPicker
            // 
            this.btnCityPicker.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCityPicker.Location = new System.Drawing.Point(12, 318);
            this.btnCityPicker.Name = "btnCityPicker";
            this.btnCityPicker.Size = new System.Drawing.Size(253, 79);
            this.btnCityPicker.TabIndex = 7;
            this.btnCityPicker.Text = "选择地区";
            this.btnCityPicker.UseVisualStyleBackColor = true;
            this.btnCityPicker.Click += new System.EventHandler(this.btnCityPicker_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(275, 318);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(253, 79);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "刷新信息";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDetails.Location = new System.Drawing.Point(12, 406);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(253, 79);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "详细信息";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarm.Location = new System.Drawing.Point(275, 406);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(253, 79);
            this.btnAlarm.TabIndex = 10;
            this.btnAlarm.Text = "评价参考";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 499);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCityPicker);
            this.Controls.Add(this.lblWindDesc);
            this.Controls.Add(this.lblTempDesc);
            this.Controls.Add(this.lblRhDesc);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblRh);
            this.Controls.Add(this.lblFeel);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "天气查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFeel;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblRhDesc;
        private System.Windows.Forms.Label lblTempDesc;
        private System.Windows.Forms.Label lblWindDesc;
        private System.Windows.Forms.Button btnCityPicker;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAlarm;
    }
}

