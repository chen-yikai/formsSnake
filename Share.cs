﻿using System;
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
        public static int moveLength = 150;
        public static int moveSpeed = 500;
        private static int _bodyLength = 0;
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
        public static void setPos(int index, int x, int y)
        {
            if (_snakePos.Count <= index)
            {
                _snakePos.Add(new Target(x, y));
                SnakeMove?.Invoke();
                return;
            }
            _snakePos[index] = new Target(x, y);
            SnakeMove?.Invoke();
        }
    }
}