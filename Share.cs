using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsSnake
{
    internal class Share
    {
        public static event Action SnakeMove;
        private static int[][] _snakePos = new int[100][];
        public static int bodyLength = 4;
        public static int[][] snakePos
        {
            get => _snakePos;
            set
            {
                _snakePos = value;
                SnakeMove?.Invoke();
            }
        }
    }
}
