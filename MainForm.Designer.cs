namespace WeatherNotification
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            trayIcon = new NotifyIcon(components);
            pboxIcon = new PictureBox();
            colorDialog = new ColorDialog();
            grpBox = new GroupBox();
            lblHumidity = new Label();
            lblHumidityText = new Label();
            lblWindSpeedData = new Label();
            lblWindSpeed = new Label();
            lblFeelsLike = new Label();
            lblReal = new Label();
            lblFeelsLikeData = new Label();
            lblTemperature = new Label();
            lblLastUpdate = new Label();
            lblLocation = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxIcon).BeginInit();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.Text = "notifyIcon1";
            trayIcon.Visible = true;
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // pboxIcon
            // 
            pboxIcon.Location = new Point(167, 22);
            pboxIcon.Name = "pboxIcon";
            pboxIcon.Size = new Size(76, 78);
            pboxIcon.TabIndex = 0;
            pboxIcon.TabStop = false;
            // 
            // colorDialog
            // 
            colorDialog.SolidColorOnly = true;
            // 
            // grpBox
            // 
            grpBox.Controls.Add(lblHumidity);
            grpBox.Controls.Add(lblHumidityText);
            grpBox.Controls.Add(lblWindSpeedData);
            grpBox.Controls.Add(lblWindSpeed);
            grpBox.Controls.Add(lblFeelsLike);
            grpBox.Controls.Add(lblReal);
            grpBox.Controls.Add(lblFeelsLikeData);
            grpBox.Controls.Add(lblTemperature);
            grpBox.Controls.Add(pboxIcon);
            grpBox.Location = new Point(12, 12);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(249, 127);
            grpBox.TabIndex = 3;
            grpBox.TabStop = false;
            grpBox.Text = "Temperature";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Location = new Point(84, 85);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(42, 15);
            lblHumidity.TabIndex = 8;
            lblHumidity.Text = "15 kph";
            // 
            // lblHumidityText
            // 
            lblHumidityText.AutoSize = true;
            lblHumidityText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHumidityText.Location = new Point(13, 85);
            lblHumidityText.Name = "lblHumidityText";
            lblHumidityText.Size = new Size(58, 15);
            lblHumidityText.TabIndex = 7;
            lblHumidityText.Text = "Humidity";
            // 
            // lblWindSpeedData
            // 
            lblWindSpeedData.AutoSize = true;
            lblWindSpeedData.Location = new Point(84, 64);
            lblWindSpeedData.Name = "lblWindSpeedData";
            lblWindSpeedData.Size = new Size(42, 15);
            lblWindSpeedData.TabIndex = 6;
            lblWindSpeedData.Text = "15 kph";
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWindSpeed.Location = new Point(13, 64);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(36, 15);
            lblWindSpeed.TabIndex = 5;
            lblWindSpeed.Text = "Wind";
            // 
            // lblFeelsLike
            // 
            lblFeelsLike.AutoSize = true;
            lblFeelsLike.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeelsLike.Location = new Point(13, 43);
            lblFeelsLike.Name = "lblFeelsLike";
            lblFeelsLike.Size = new Size(58, 15);
            lblFeelsLike.TabIndex = 4;
            lblFeelsLike.Text = "Feels like";
            // 
            // lblReal
            // 
            lblReal.AutoSize = true;
            lblReal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReal.Location = new Point(13, 22);
            lblReal.Name = "lblReal";
            lblReal.Size = new Size(65, 15);
            lblReal.TabIndex = 3;
            lblReal.Text = "Real Temp";
            // 
            // lblFeelsLikeData
            // 
            lblFeelsLikeData.AutoSize = true;
            lblFeelsLikeData.Location = new Point(84, 43);
            lblFeelsLikeData.Name = "lblFeelsLikeData";
            lblFeelsLikeData.Size = new Size(35, 15);
            lblFeelsLikeData.TabIndex = 2;
            lblFeelsLikeData.Text = "26° C";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(84, 22);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(35, 15);
            lblTemperature.TabIndex = 1;
            lblTemperature.Text = "25° C";
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.AutoSize = true;
            lblLastUpdate.Location = new Point(12, 171);
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(108, 15);
            lblLastUpdate.TabIndex = 5;
            lblLastUpdate.Text = "Last updated: 00:00";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(12, 142);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(155, 15);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Location: Olivos, Argentina\r\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 195);
            Controls.Add(lblLocation);
            Controls.Add(lblLastUpdate);
            Controls.Add(grpBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Notificator";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)pboxIcon).EndInit();
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon trayIcon;
        private PictureBox pboxIcon;
        private ColorDialog colorDialog;
        private GroupBox grpBox;
        private Label lblFeelsLikeData;
        private Label lblTemperature;
        private Label lblWindSpeed;
        private Label lblFeelsLike;
        private Label lblReal;
        private Label lblWindSpeedData;
        private Label lblHumidity;
        private Label lblHumidityText;
        private Label lblLastUpdate;
        private Label lblLocation;
    }
}
