﻿using CommunityToolkit.Maui.Alerts;

namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        string hexvalue = string.Empty; 
        bool israndom = false;
        private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!israndom)
            {
                var red = sldRed.Value;
                var blue = sldBlue.Value;
                var green = sldGreen.Value;
                Color color = Color.FromRgb(red, green, blue);

                SetColor(color);
            }
        }
        private void SetColor(Color color)
        {
            Container.BackgroundColor = color;
            hexvalue = color.ToHex();
            lblHex.Text = hexvalue;
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(hexvalue);
            var toast = Toast.Make("copied to clipboard", CommunityToolkit.Maui.Core.ToastDuration.Short,13);
            await toast.Show();
        }

        private void Btnrandom_Clicked(object sender, EventArgs e)
        {
            israndom = true;
            var random = new Random();

            var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;

            SetColor(color);
            israndom = false;
        }
    }

}
