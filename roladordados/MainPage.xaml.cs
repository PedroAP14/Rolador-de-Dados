namespace roladordados
{
    public partial class MainPage : ContentPage
    {
        Random aleatorio = new Random();
        int dado;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RolarDadoButton_Clicked(object sender, EventArgs e)
        {
            DadoRespostaLabel.TextColor = Microsoft.Maui.Graphics.Colors.Black;
            switch (LadoDadoPicker.SelectedIndex)
            {
                case 0:
                    dado = aleatorio.Next(1, 5);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 1:
                    dado = aleatorio.Next(1, 7);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 2:
                    dado = aleatorio.Next(1, 9);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 3:
                    dado = aleatorio.Next(1, 11);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 4:
                    dado = aleatorio.Next(1, 13);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 5:
                    dado = aleatorio.Next(1, 21);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                case 6:
                    dado = aleatorio.Next(1, 101);
                    DadoRespostaLabel.Text = $"{dado}";
                    break;

                default:
                    DadoRespostaLabel.Text = "Escolha um tipo de Dado!!!";
                    DadoRespostaLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
                    break;
            }
        }

        private void LadoDadoPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LadoDadoPicker.SelectedIndex)
            {
                case 0:
                    ImagemDado.Source = "d4.PNG";
                    break;

                case 1:
                    ImagemDado.Source = "d6.PNG";
                    break;

                case 2:
                    ImagemDado.Source = "d8.PNG";
                    break;

                case 3:
                    ImagemDado.Source = "d10.PNG";
                    break;

                case 4:
                    ImagemDado.Source = "d12.PNG";
                    break;

                case 5:
                    ImagemDado.Source = "d20.PNG";
                    break;

                case 6:
                    ImagemDado.Source = "d100.PNG";
                    break;

                default:
                    ImagemDado.Source = "dado.PNG";
                    break;
            }            
        }
    }
}
