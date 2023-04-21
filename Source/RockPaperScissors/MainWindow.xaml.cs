using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RockPaperScissors
{
    public partial class MainWindow : Window
    {
        static GameManager game = new GameManager();
        static readonly Random rnd = new Random();


        // --- Main logic ---

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Play(object sender, RoutedEventArgs e)
        {
            game.SetChoices(CBox_PlayerChoice.SelectedIndex, rnd.Next(0, 3));
            game.DetermineWinner();

            SetOpponentImage();
            SetLabels();
        }

        private void SetOpponentImage()
        {
            switch (game.OpponentChoice)
            {
                case GameManager.Choice.Rock:
                    InternalSetOpponentImage("rock.png");
                    break;

                case GameManager.Choice.Paper:
                    InternalSetOpponentImage("paper.png");
                    break;

                case GameManager.Choice.Scissors:
                    InternalSetOpponentImage("scissors.png");
                    break;
            }
        }

        private void InternalSetOpponentImage(string source)
        {
            Image_Opponent.Source = new BitmapImage(new Uri("Resources/rps_" + source, UriKind.Relative));
        }

        private void SetLabels()
        {
            switch (game.GameWinner)
            {
                case GameManager.Winner.Player:
                    InternalSetLabels("You win!", ++game.PlayerWins, game.OpponentWins);
                    break;

                case GameManager.Winner.Opponent:
                    InternalSetLabels("CPU wins!", game.PlayerWins, ++game.OpponentWins);
                    break;

                case GameManager.Winner.Draw:
                    InternalSetLabels("It's a draw!", game.PlayerWins, game.OpponentWins);
                    break;
            }
        }

        private void InternalSetLabels(string winnerLabel, int playerWins, int opponentWins)
        {
            Label_Winner.Content = winnerLabel;

            Label_PlayerScore.Content = playerWins;
            Label_OpponentScore.Content = opponentWins;

            TextBlock_RoundNum.Text = string.Format("Round {0}", game.Round);
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            game.Round = 0;
            InternalSetLabels(string.Empty, game.PlayerWins = 0, game.OpponentWins = 0);
            InternalSetOpponentImage("unknown.png");
        }


        // --- Miscellaneous ---

        private void Menu_Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Menu_Button_About_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)  // Used for changing the player's selection with shortcut keys
            {
                case Key.R:
                    CBox_PlayerChoice.SelectedIndex = 0;
                    break;

                case Key.P:
                    CBox_PlayerChoice.SelectedIndex = 1;
                    break;

                case Key.S:
                    CBox_PlayerChoice.SelectedIndex = 2;
                    break;

                default:
                    break;
            }
        }
    }

    class GameManager
    {
        public int Round { get; set; }
        public int PlayerWins { get; set; }
        public int OpponentWins { get; set; }

        public Choice PlayerChoice { get; private set; }
        public Choice OpponentChoice { get; private set; }
        public Winner GameWinner { get; private set; }


        public void SetChoices(int playerChoice, int opponentChoice)
        {
            PlayerChoice = (Choice)playerChoice;
            OpponentChoice = (Choice)opponentChoice;
        }

        public void DetermineWinner()
        {
            ++Round;

            if (PlayerChoice == OpponentChoice)
            {
                GameWinner = Winner.Draw;
                return;
            }

            switch (PlayerChoice)
            {
                case Choice.Rock:
                    SetWinner(Choice.Paper);
                    break;

                case Choice.Paper:
                    SetWinner(Choice.Scissors);
                    break;

                case Choice.Scissors:
                    SetWinner(Choice.Rock);
                    break;
            }
        }

        private void SetWinner(Choice ch)
        {
            GameWinner = (OpponentChoice == ch) ? Winner.Opponent : Winner.Player;
        }

        public enum Choice
        {
            // Numbered for clarification

            Rock     = 0,
            Paper    = 1,
            Scissors = 2
        }

        public enum Winner
        {
            Player   = 0,
            Opponent = 1,
            Draw     = 2
        }
    }
}
