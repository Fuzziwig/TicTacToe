using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        private Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(2, 0); // Bottom Left
                case 2: return new Position(2, 1); // Bottom Middle 
                case 3: return new Position(2, 2); // Bottom Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(0, 0); // Top Left
                case 8: return new Position(0, 1); // Top Middle
                case 9: return new Position(0, 2); // Top Right
                default: return null;
            }
        }
    }
}
