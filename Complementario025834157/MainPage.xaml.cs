namespace Complementario025834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Obtenemos los numeros ingresados y validarlos
            if (double.TryParse(NumeroA.Text, out double numeroA) && double.TryParse(NumeroB.Text, out double numeroB))
            {
                // calculará la expresión de (A + B) 2/2
                double resultado = Math.Pow(numeroA + numeroB, 2) / 2;

            //Nos mostrara el resultado de la expresión matematica
                ResultLabel.Text = $"Resultado: {resultado}";
            }
           

        }
    }

}
