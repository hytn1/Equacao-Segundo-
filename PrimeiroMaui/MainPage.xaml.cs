

namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);
            double n3 = Convert.ToDouble(txt_n3.Text);

            double delta = (n2*n2) - (4*n1*n3);

            if (delta < 0)
            {
                string msg1 = $"O resultado do delta {delta} é uam raiz irreal";

                DisplayAlert("Resultado", msg1, "Fechar");

            }
            else
            {
                double x1 = ((-1 * n2) + Math.Sqrt(delta)) / (2 * n1);
                double x2 = ((-1 * n2) - Math.Sqrt(delta)) / (2 * n1);

                string msg = $"O resultado das raízes do x são  {x1} e {x2}";

                DisplayAlert("Resultado", msg, "Fechar");

            }
        }
    }

}
