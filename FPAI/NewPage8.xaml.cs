using Microsoft.Maui.Controls;

namespace FPAI
{
    public partial class NewPage8 : ContentPage
    {
        private int currentQuestion = 1;

        public NewPage8()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            switch (currentQuestion)
            {
                case 1:
                    QuestionLabel.Text = "1. ¿Cuál es el color del sable de luz de Luke Skywalker?";
                    SetButtonText("Azul", "Verde", "Rojo", "Naranja");
                    break;
                case 2:
                    QuestionLabel.Text = "2. ¿Cuál es el color del sable de luz de Mace Windu?";
                    SetButtonText("Púrpura", "Verde", "Azul", "Rojo");
                    break;
                case 3:
                    QuestionLabel.Text = "3. ¿Cuál es el rol en el juego de Yoda?";
                    SetButtonText("Sabio Jedi defensor", "Jedi versátil", "Joven Jedi", "Villano poderoso");
                    break;
                case 4:
                    QuestionLabel.Text = "4. ¿Cuál es el color del sable de luz de Darth Vader?";
                    SetButtonText("Rojo", "Verde", "Azul", "Naranja");
                    break;
                case 5:
                    QuestionLabel.Text = "5. ¿Qué habilidad especial tiene Ahsoka Tano?";
                    SetButtonText("Estilo Dual", "Telequinesis", "Vaapad", "Defensa Maestra");
                    break;
                case 6:
                    QuestionLabel.Text = "6. ¿Cuál es el color del sable de luz de Ahsoka Tano?";
                    SetButtonText("Naranja y verde", "Azul y verde", "Púrpura", "Rojo");
                    break;
                case 7:
                    QuestionLabel.Text = "7. ¿Qué habilidad especial es utilizada por Mace Windu?";
                    SetButtonText("Vaapad", "Telequinesis", "Defensa Maestra", "Evasión Ágil");
                    break;
                default:
                    QuestionLabel.Text = "¡Cuestionario completado!";
                    Button1.IsVisible = false;
                    Button2.IsVisible = false;
                    Button3.IsVisible = false;
                    Button4.IsVisible = false;
                    FeedbackLabel.Text = "";
                    NextButton.IsVisible = false;
                    break;
            }
        }

        private void SetButtonText(string button1Text, string button2Text, string button3Text, string button4Text)
        {
            Button1.Text = button1Text;
            Button2.Text = button2Text;
            Button3.Text = button3Text;
            Button4.Text = button4Text;
        }

        private async void OnAnswerButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                bool isCorrect = false;

                switch (currentQuestion)
                {
                    case 1:
                        isCorrect = clickedButton.Text == "Azul";
                        break;
                    case 2:
                        isCorrect = clickedButton.Text == "Púrpura";
                        break;
                    case 3:
                        isCorrect = clickedButton.Text == "Sabio Jedi defensor";
                        break;
                    case 4:
                        isCorrect = clickedButton.Text == "Rojo";
                        break;
                    case 5:
                        isCorrect = clickedButton.Text == "Estilo Dual";
                        break;
                    case 6:
                        isCorrect = clickedButton.Text == "Naranja y verde";
                        break;
                    case 7:
                        isCorrect = clickedButton.Text == "Vaapad";
                        break;
                }

                FeedbackLabel.Text = isCorrect ? "¡Correcto!" : "Incorrecto. Inténtalo de nuevo.";
                FeedbackLabel.TextColor = isCorrect ? Colors.Green : Colors.Red;

                if (isCorrect)
                {
                    NextButton.IsVisible = true;
                }
            }
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            currentQuestion++;
            LoadQuestion();
            FeedbackLabel.Text = string.Empty;
            NextButton.IsVisible = false;
        }
    }
}
