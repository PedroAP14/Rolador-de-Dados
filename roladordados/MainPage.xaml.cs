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
            if(LadoDadoPicker.SelectedIndex != -1)
            {
                DadoRespostaLabel.TextColor = Microsoft.Maui.Graphics.Colors.Black;

                if (LadoDadoPicker.SelectedIndex == 0)
                {
                    dado = aleatorio.Next(1,5);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d4.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 1)
                {
                    dado = aleatorio.Next(1, 7);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d6.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 2)
                {
                    dado = aleatorio.Next(1, 9);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d8.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 3)
                {
                    dado = aleatorio.Next(1, 11);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d10.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 4)
                {
                    dado = aleatorio.Next(1, 13);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d12.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 5)
                {
                    dado = aleatorio.Next(1, 21);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d20.PNG";
                }
                else if (LadoDadoPicker.SelectedIndex == 6)
                {
                    dado = aleatorio.Next(1, 101);
                    DadoRespostaLabel.Text = $"{dado}";
                    ImagemDado.Source = "d100.PNG";
                }

            }
            else
            {
                DadoRespostaLabel.Text = "Escolha um tipo de Dado!!!";
                DadoRespostaLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
                ImagemDado.Source = "dado.PNG";
            }

        }
    }
}
