using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using WeatherNotification.Controllers;
using WeatherNotification.Model;

namespace WeatherNotification
{
    public partial class MainForm : Form
    {
        private Thread _updateThread;
        bool _firstTimeDone = false;
        private const int HALF_HOUR = 1800000;
        private const string DISCONNECTED = "DC";

        private GeolocationData? CurrentPosition { get; set; }
        private WeatherData? Weather { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _updateThread = new Thread(UpdateData);
            this.WindowState = FormWindowState.Minimized;
            RefreshIconImage();

        }

        private void RefreshIconImage(bool modifyTray = false)
        {

            //pnlBackground.BackColor = IconController.BackgroundColor;
            //pnlForeground.BackColor = IconController.ForegroundColor;

            //string msgShown = DISCONNECTED;
            //if(Weather != null)
            //{
            //    int temp = (int)Weather.GetWeather();
            //}
            //pictureBox1.Image = IconController.GenerateImage();

        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            CurrentPosition = await CurrentLocationControler.GetCurrentPosition();
            Weather = null;

            if (CurrentPosition != null)
                Weather = await WeatherController.GetWeatherDataAsync(CurrentPosition.Latitude, CurrentPosition.Longitude);

            if (Weather == null)
            {
                RefreshDisconnectedIcon();
            }
            else
            {
                RefreshIcon(Weather);
            }
            trayIcon.Visible = true;

            _updateThread.Start();
        }


        private async void UpdateData()
        {
            while (true)
            {
                Thread.Sleep(HALF_HOUR);

                Weather = null;
                if (CurrentPosition != null)
                    Weather = await WeatherController.GetWeatherDataAsync(CurrentPosition.Latitude, CurrentPosition.Longitude);

                if (Weather == null)
                {
                    return;
                }

                RefreshIcon(Weather);


            }
        }

        private void RefreshIcon(WeatherData weatherData)
        {
            int celsius = (int)weatherData.Current.TemperatureCelsius;
            trayIcon.Text = $"{celsius}° Celsius in {CurrentPosition?.City ?? "here"}";
            trayIcon.Icon = IconController.GenerateIcon(celsius.ToString());
        }
        private void RefreshDisconnectedIcon()
        {
            trayIcon.Icon = IconController.GenerateIcon(DISCONNECTED);
        }


        private Color? ShowColorDialog()
        {

            var dr = colorDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {

                return colorDialog.Color;
            }

            return null;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState != FormWindowState.Normal)
            {

                LoadDataPanel();
                this.StartPosition = FormStartPosition.CenterScreen;
                this.TopLevel = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }else if(WindowState == FormWindowState.Normal)
            {
                BringFromToFront();
            }
            
        }

        private void BringFromToFront()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void LoadDataPanel()
        {
            if(Weather == null || CurrentPosition == null)
            {
                return;
            }
            lblFeelsLikeData.Text = Weather.Current.FeelsLikeCelsius.ToString();
            lblTemperature.Text = Weather.Current.TemperatureCelsius.ToString();
            lblWindSpeedData.Text = $"{Weather.Current.WindSpeedKph}kph";
            lblHumidity.Text = $"{Weather.Current.Humidity}%";

            lblLastUpdate.Text = $"Last update: {Weather.Current.LastUpdated}";
            lblLocation.Text = $"{CurrentPosition.City}, {CurrentPosition.RegionName}";

            LoadPictureBox();
        }

        private void LoadPictureBox()
        {

            if(Weather == null)
            {
                return;
            }

            pboxIcon.Image = IconController.GetImageFromUrl(Weather.Current.Condition.IconUrl.Replace("//",""));

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
                this.Hide();
            }
            
        }
    }
}
