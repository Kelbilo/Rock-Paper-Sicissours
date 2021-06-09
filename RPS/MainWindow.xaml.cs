using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] aiChoice = new string[3];
        public int playerScore;
        public int aiScore;
        public MainWindow()
        {
            InitializeComponent();
            aiChoice[0] = "Rock";
            aiChoice[1] = "Paper";
            aiChoice[2] = "Scissours";
        }

        public void CheckWin()
        {
            if (choiceTxt.Text == "Rock" && AItxt.Text == "Rock")
            {
                none.Text = "Draw";
            }
            else if (choiceTxt.Text == "Paper" && AItxt.Text == "Rock")
            {
                none.Text = "You Win";
                playerScore++;
            }
            else if (choiceTxt.Text == "Scissours" && AItxt.Text == "Rock")
            {
                none.Text = "AI Win";
                aiScore++;
            }
            else if (choiceTxt.Text == "Rock" && AItxt.Text == "Paper")
            {
                none.Text = "AI Win";
                aiScore++;
            }
            else if (choiceTxt.Text == "Paper" && AItxt.Text == "Paper")
            {
                none.Text = "Draw";
            }
            else if (choiceTxt.Text == "Scissours" && AItxt.Text == "Paper")
            {
                none.Text = "You Win";
                playerScore++;
            }
            else if (choiceTxt.Text == "Rock" && AItxt.Text == "Scissours")
            {
                none.Text = "You Win";
                playerScore++;
            }
            else if (choiceTxt.Text == "Paper" && AItxt.Text == "Scissours")
            {
                none.Text = "AI Win";
                aiScore++;
            }
            else if (choiceTxt.Text == "Scissours" && AItxt.Text == "Scissours")
            {
                none.Text = "Draw";
            }
            playerPointTxt.Text = playerScore.ToString();
            AiPointTxt.Text = aiScore.ToString();
        }

        private void rockBtn_Click(object sender, RoutedEventArgs e)
        {
            choiceTxt.Text = "Rock";
            Random r = new Random();
            int ai = r.Next(0, 3);
            AItxt.Text = aiChoice[ai];
            CheckWin();
        }

        private void paperBtn_Click(object sender, RoutedEventArgs e)
        {
            choiceTxt.Text = "Paper";
            Random r = new Random();
            int ai = r.Next(0, 3);
            AItxt.Text = aiChoice[ai];
            CheckWin();
        }

        private void scissBtn_Click(object sender, RoutedEventArgs e)
        {
            choiceTxt.Text = "Scissours";
            Random r = new Random();
            int ai = r.Next(0, 3);
            AItxt.Text = aiChoice[ai];
            CheckWin();
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            playerPointTxt.Text = "0";
            AiPointTxt.Text = "0";
            none.Text = "-";
        }
    }
}
