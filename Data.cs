using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTicTacToe
{
    class Data
    {
        public char[,] GameGrid = new char[3,3];
        public int PlayerOneWins = 0;
        public int PlayerTwoWins = 0;
        public bool bPlayerOne = true;
        public bool bGameIsOver = false;
        public Vector2 LastMoveMade = new Vector2();
    }
}
