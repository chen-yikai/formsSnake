using System;
using System.Collections.Generic;

namespace formsSnake
{
    public class Target
    {
        public int x;
        public int y;
        public Target(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Share
    {
        public static event Action SnakeMove;
        public static event Action lengthChange;
        public static event Action gameOvered;
        public static int moveLength = Properties.Settings.Default.moveLength;
        public static int moveSpeed = Properties.Settings.Default.speed;
        private static int _bodyLength = 1;
        public static int bodyLength
        {
            get => _bodyLength;
            set
            {
                _bodyLength = value;
                lengthChange?.Invoke();
            }
        }
        private static List<Target> _snakePos = new List<Target>();
        public static List<Target> snakePos
        {
            get => _snakePos;
            set
            {
                _snakePos = value;
                SnakeMove?.Invoke();
            }
        }
        public static void GameOver()
        {
            gameOvered?.Invoke();
        }
        public static void clearPos()
        {
            _snakePos.Clear();
        }
        public static void setPos(int x, int y)
        {
            _snakePos.Add(new Target(x, y));
            if (_snakePos.Count > bodyLength) _snakePos.RemoveAt(0);
            SnakeMove?.Invoke();
        }
    }
}