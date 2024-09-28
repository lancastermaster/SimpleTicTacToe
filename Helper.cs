using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicTacToe
{
    class Helper
    {
        public Data GameData = new Data();
        public MainWindow MainWindow;

        public void MarkGridCoords(int XCoord, int YCoord)
        {
            if (GameData.bGameIsOver == false)
            {
                if (GameData.bPlayerOne)
                {
                    GameData.GameGrid[XCoord, YCoord] = 'X';
                    GameData.bPlayerOne = false;
                }
                else
                {
                    GameData.GameGrid[XCoord, YCoord] = 'O';
                    GameData.bPlayerOne = true;
                }
            }
                IsGameOver();
        }

        public void IsGameOver()
        {
            if (GameData.bGameIsOver) return;

            //check for rows of three X's
            if ((GameData.GameGrid[0, 0] == 'X' && GameData.GameGrid[1, 0] == 'X' && GameData.GameGrid[2, 0] == 'X')
                || (GameData.GameGrid[0, 1] == 'X' && GameData.GameGrid[1, 1] == 'X' && GameData.GameGrid[2, 1] == 'X')
                || (GameData.GameGrid[0, 2] == 'X' && GameData.GameGrid[1, 2] == 'X' && GameData.GameGrid[2, 2] == 'X')
                || (GameData.GameGrid[0, 0] == 'X' && GameData.GameGrid[0, 1] == 'X' && GameData.GameGrid[0, 2] == 'X')
                || (GameData.GameGrid[1, 0] == 'X' && GameData.GameGrid[1, 1] == 'X' && GameData.GameGrid[1, 2] == 'X')
                || (GameData.GameGrid[2, 0] == 'X' && GameData.GameGrid[2, 1] == 'X' && GameData.GameGrid[2, 2] == 'X')
                || (GameData.GameGrid[0, 0] == 'X' && GameData.GameGrid[1, 1] == 'X' && GameData.GameGrid[2, 2] == 'X')
                || (GameData.GameGrid[2, 0] == 'X' && GameData.GameGrid[1, 1] == 'X' && GameData.GameGrid[0, 2] == 'X'))
            {
                GameData.PlayerOneWins += 1;
                MainWindow.labelPlayer1Score.Content = GameData.PlayerOneWins.ToString();
                GameData.bGameIsOver = true;
                return;
            }

            //check for rows of three O's
            else if ((GameData.GameGrid[0, 0] == 'O' && GameData.GameGrid[1, 0] == 'O' && GameData.GameGrid[2, 0] == 'O')
                || (GameData.GameGrid[0, 1] == 'O' && GameData.GameGrid[1, 1] == 'O' && GameData.GameGrid[2, 1] == 'O')
                || (GameData.GameGrid[0, 2] == 'O' && GameData.GameGrid[1, 2] == 'O' && GameData.GameGrid[2, 2] == 'O')
                || (GameData.GameGrid[0, 0] == 'O' && GameData.GameGrid[0, 1] == 'O' && GameData.GameGrid[0, 2] == 'O')
                || (GameData.GameGrid[1, 0] == 'O' && GameData.GameGrid[1, 1] == 'O' && GameData.GameGrid[1, 2] == 'O')
                || (GameData.GameGrid[2, 0] == 'O' && GameData.GameGrid[2, 1] == 'O' && GameData.GameGrid[2, 2] == 'O')
                || (GameData.GameGrid[0, 0] == 'O' && GameData.GameGrid[1, 1] == 'O' && GameData.GameGrid[2, 2] == 'O')
                || (GameData.GameGrid[2, 0] == 'O' && GameData.GameGrid[1, 1] == 'O' && GameData.GameGrid[0, 2] == 'O'))
            {
                GameData.PlayerTwoWins += 1;
                MainWindow.labelPlayer2Score.Content = GameData.PlayerTwoWins.ToString();
                GameData.bGameIsOver = true;
                return;
            }

            /*else 
            {

                foreach (char c in GameData.GameGrid)
                {
                    if (c != ' ')
                    {
                        GameData.bGameIsOver = true;
                        return;
                    }
                    else 
                    {
                        GameData.bGameIsOver = true;
                    }
                }
            }*/
        }

        public void ResetGame()
        {
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    GameData.GameGrid[x, y] = ' ';
                }
            }

            MainWindow.button1_1.Content = GameData.GameGrid[0, 0];
            MainWindow.button1_2.Content = GameData.GameGrid[0, 1];
            MainWindow.button1_3.Content = GameData.GameGrid[0, 2];
            MainWindow.button2_1.Content = GameData.GameGrid[1, 0];
            MainWindow.button2_2.Content = GameData.GameGrid[1, 1];
            MainWindow.button2_3.Content = GameData.GameGrid[1, 2];
            MainWindow.button3_1.Content = GameData.GameGrid[2, 0];
            MainWindow.button3_2.Content = GameData.GameGrid[2, 1];
            MainWindow.button3_3.Content = GameData.GameGrid[2, 2];

            GameData.bPlayerOne = true;
            GameData.bGameIsOver = false;
        }

        public void SetLastMove(int InX, int InY)
        {
            GameData.LastMoveMade.X = InX;
            GameData.LastMoveMade.Y = InY;
        }
    }
}
