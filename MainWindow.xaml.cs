using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper helper = new Helper();

        public MainWindow()
        {
            InitializeComponent();
            helper.MainWindow = this;
        }



        private void button1_1_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(0, 0);
            helper.SetLastMove(0, 0);

            //set button text to char in grid
            button1_1.Content = helper.GameData.GameGrid[0, 0];
        }

            private void button1_2_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(1, 0);
            helper.SetLastMove(1, 0);

            button1_2.Content = helper.GameData.GameGrid[1, 0];
        }

        private void button1_3_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(2, 0);
            helper.SetLastMove(2, 0);

            button1_3.Content = helper.GameData.GameGrid[2, 0];
        }

        private void button2_1_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(0, 1);
            helper.SetLastMove(0, 1);

            button2_1.Content = helper.GameData.GameGrid[0, 1];
        }

        private void button2_2_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(1, 1);
            helper.SetLastMove(1, 1);

            button2_2.Content = helper.GameData.GameGrid[1, 1];
        }

        private void button2_3_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(2, 1);
            helper.SetLastMove(2, 1);

            button2_3.Content = helper.GameData.GameGrid[2, 1];
        }

        private void button3_1_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(0, 2);
            helper.SetLastMove(0, 2);

            button3_1.Content = helper.GameData.GameGrid[0, 2];
        }

        private void button3_2_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(1, 2);
            helper.SetLastMove(1, 2);

            button3_2.Content = helper.GameData.GameGrid[1, 2];
        }

        private void button3_3_Click(object sender, RoutedEventArgs e)
        {
            helper.MarkGridCoords(2, 2);
            helper.SetLastMove(2, 2);

            button3_3.Content = helper.GameData.GameGrid[2, 2];
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            helper.ResetGame();

            //reset button content
            /*button1_1.Content = helper.GameData.GameGrid[0, 0];
            button1_2.Content = helper.GameData.GameGrid[0, 1];
            button1_3.Content = helper.GameData.GameGrid[0, 2];
            button2_1.Content = helper.GameData.GameGrid[1, 0];
            button2_2.Content = helper.GameData.GameGrid[1, 1];
            button2_3.Content = helper.GameData.GameGrid[1, 2];
            button3_1.Content = helper.GameData.GameGrid[2, 0];
            button3_2.Content = helper.GameData.GameGrid[2, 1];
            button3_3.Content = helper.GameData.GameGrid[2, 2];*/
        }
    }
}