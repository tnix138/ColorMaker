namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;
            var blue = sldBlue.Value;
            var green = sldGreen.Value;
            Color color = Color.FromRgb(red,green,blue);

            setColor(color);

        } 
        private void setColor(Color color)
        {
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void btnrandom_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            var color = Color.FromRgb(random.Next(0, 256),random.Next(0, 256),random.Next(0, 256));

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;

            setColor(color);
        }
    }

}
