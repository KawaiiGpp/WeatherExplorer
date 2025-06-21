namespace WeatherExplorer.Forms.Alarm
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            this.lvAlarmList = new System.Windows.Forms.ListView();
            this.imglAlarmList = new System.Windows.Forms.ImageList(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAlarmList
            // 
            this.lvAlarmList.Enabled = false;
            this.lvAlarmList.HideSelection = false;
            this.lvAlarmList.Location = new System.Drawing.Point(32, 105);
            this.lvAlarmList.MultiSelect = false;
            this.lvAlarmList.Name = "lvAlarmList";
            this.lvAlarmList.Size = new System.Drawing.Size(560, 280);
            this.lvAlarmList.SmallImageList = this.imglAlarmList;
            this.lvAlarmList.TabIndex = 0;
            this.lvAlarmList.UseCompatibleStateImageBehavior = false;
            this.lvAlarmList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imglAlarmList
            // 
            this.imglAlarmList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglAlarmList.ImageSize = new System.Drawing.Size(90, 72);
            this.imglAlarmList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(33, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(559, 57);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "仅基于实时天气信息，提供有限的的天气评价提示、天气恶劣程度评估\r\n不具备预报、预警功能，具体预警信息以及相关指引请以官方为准";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 428);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvAlarmList);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmForm";
            this.Text = "天气评价参考";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAlarmList;
        private System.Windows.Forms.ImageList imglAlarmList;
        private System.Windows.Forms.Label lblTitle;
    }
}