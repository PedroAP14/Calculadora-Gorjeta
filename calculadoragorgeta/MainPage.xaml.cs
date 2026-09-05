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
            ValorGorgetaLabel.Text = Math.Floor(Convert.ToDouble(ValorGorgetaLabel.Text)).ToString();

            double valorGorgeta = Convert.ToDouble(ValorGorgetaLabel.Text);
            valorConta = Convert.ToDouble(ValorContaEntry.Text);
            ValorTotalLabel.Text = $"{valorConta + valorGorgeta}";
        }

        private void BotaoArrendodarParaCimaButton_Clicked(object sender, EventArgs e)
        {
            ValorGorgetaLabel.Text = Math.Ceiling(Convert.ToDouble(ValorGorgetaLabel.Text)).ToString();

            double valorGorgeta = Convert.ToDouble(ValorGorgetaLabel.Text);
            valorConta = Convert.ToDouble(ValorContaEntry.Text);
            ValorTotalLabel.Text = $"{valorConta + valorGorgeta}";
        }

        private void PorcetagemValorSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            PercentualGorgetaLabel.Text = $"{Math.Round(PorcetagemValorSlider.Value, 2)} %";
            valorConta = Convert.ToDouble(ValorContaEntry.Text);
            double valorGorgeta = valorConta * (PorcetagemValorSlider.Value / 100);

            ValorGorgetaLabel.Text = $"{valorGorgeta}";
            ValorTotalLabel.Text = $"{valorConta + valorGorgeta}";
        }
    }
}