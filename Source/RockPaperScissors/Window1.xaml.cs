using System.Windows;
using System.Windows.Input;

namespace RockPaperScissors
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBlock_GithubLink_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wirmaple73");
        }
    }
}
