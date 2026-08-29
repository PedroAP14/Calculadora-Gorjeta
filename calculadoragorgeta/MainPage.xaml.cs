namespace calculadoragorgeta
{
    public partial class MainPage : ContentPage
    {
        double valorConta = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Gorgeta15PorcentoButton_Clicked(object sender, EventArgs e)
        {
            PercentualGorgetaLabel.Text = "15%";
        }

        private void Gorgeta20PorcentoButton_Clicked(object sender, EventArgs e)
        {
            PercentualGorgetaLabel.Text = "20%";
        }

        private void ArrendondarParaBaixoButton_Clicked(object sender, EventArgs e)
        {

        }

        private void BotaoArrendodarParaCimaButton_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcetagemValorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PercentualGorgetaLabel.Text = PorcetagemValorSlider.Value.ToString();
            valorConta = Convert.ToDouble(ValorContaEntry.Text);
            double valorGorgeta = valorConta * (PorcetagemValorSlider.Value / 100);

            ValorGorgetaLabel.Text = valorGorgeta.ToString(); 
        }
    }
}
