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
            pictureBox1 = new PictureBox();
            colorDialog = new ColorDialog();
            btnForeground = new Button();
            btnBackground = new Button();
            grpBox = new GroupBox();
            pnlBackground = new Panel();
            pnlForeground = new Panel();
            groupBox1 = new GroupBox();
            radioButtonFahrenheit = new RadioButton();
            radioBtnCelsius = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.Text = "notifyIcon1";
            trayIcon.Visible = true;
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(182, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // colorDialog
            // 
            colorDialog.SolidColorOnly = true;
            // 
            // btnForeground
            // 
            btnForeground.Location = new Point(6, 22);
            btnForeground.Name = "btnForeground";
            btnForeground.Size = new Size(101, 24);
            btnForeground.TabIndex = 1;
            btnForeground.Text = "Foreground";
            btnForeground.UseVisualStyleBackColor = true;
            btnForeground.Click += btnForeground_Click;
            // 
            // btnBackground
            // 
            btnBackground.Location = new Point(6, 61);
            btnBackground.Name = "btnBackground";
            btnBackground.Size = new Size(101, 23);
            btnBackground.TabIndex = 2;
            btnBackground.Text = "Background";
            btnBackground.UseVisualStyleBackColor = true;
            btnBackground.Click += btnBackground_Click;
            // 
            // grpBox
            // 
            grpBox.Controls.Add(pnlBackground);
            grpBox.Controls.Add(pnlForeground);
            grpBox.Controls.Add(pictureBox1);
            grpBox.Controls.Add(btnBackground);
            grpBox.Controls.Add(btnForeground);
            grpBox.Location = new Point(12, 12);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(249, 106);
            grpBox.TabIndex = 3;
            grpBox.TabStop = false;
            grpBox.Text = "Icon Color";
            // 
            // pnlBackground
            // 
            pnlBackground.Location = new Point(123, 60);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(24, 24);
            pnlBackground.TabIndex = 4;
            // 
            // pnlForeground
            // 
            pnlForeground.Location = new Point(123, 22);
            pnlForeground.Name = "pnlForeground";
            pnlForeground.Size = new Size(24, 24);
            pnlForeground.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFahrenheit);
            groupBox1.Controls.Add(radioBtnCelsius);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 55);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "System";
            // 
            // radioButtonFahrenheit
            // 
            radioButtonFahrenheit.AutoSize = true;
            radioButtonFahrenheit.Location = new Point(123, 22);
            radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            radioButtonFahrenheit.Size = new Size(81, 19);
            radioButtonFahrenheit.TabIndex = 1;
            radioButtonFahrenheit.Text = "Fahrenheit";
            radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioBtnCelsius
            // 
            radioBtnCelsius.AutoSize = true;
            radioBtnCelsius.Checked = true;
            radioBtnCelsius.Location = new Point(13, 22);
            radioBtnCelsius.Name = "radioBtnCelsius";
            radioBtnCelsius.Size = new Size(62, 19);
            radioBtnCelsius.TabIndex = 0;
            radioBtnCelsius.TabStop = true;
            radioBtnCelsius.Text = "Celsius";
            radioBtnCelsius.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 185);
            Controls.Add(groupBox1);
            Controls.Add(grpBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Notificator";
            Load += MainForm_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon trayIcon;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog;
        private Button btnForeground;
        private Button btnBackground;
        private GroupBox grpBox;
        private Panel pnlBackground;
        private Panel pnlForeground;
        private GroupBox groupBox1;
        private RadioButton radioButtonFahrenheit;
        private RadioButton radioBtnCelsius;
    }
}
