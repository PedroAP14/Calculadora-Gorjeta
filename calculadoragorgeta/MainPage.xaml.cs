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
            PorcetagemValorSlider.Value = 15;
        }

        private void Gorgeta20PorcentoButton_Clicked(object sender, EventArgs e)
        {
            PorcetagemValorSlider.Value = 20;
        }

        private void ArrendondarParaBaixoButton_Clicked(object sender, EventArgs e)
        {

        }

        private void BotaoArrendodarParaCimaButton_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcetagemValorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PercentualGorgetaLabel.Text = PorcetagemValorSlider.Value.ToString() + "%";
            valorConta = Convert.ToDouble(ValorContaEntry.Text);
            double valorGorgeta = valorConta * (PorcetagemValorSlider.Value / 100);

            ValorGorgetaLabel.Text = valorGorgeta.ToString();
            ValorTotalLabel.Text = (valorConta + valorGorgeta).ToString();
        }
    }
}
