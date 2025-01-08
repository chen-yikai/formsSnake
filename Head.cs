using System;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class Head : Form
    {
        public string direction = "";
        public Head()
        {
            InitializeComponent();
        }

        private void Head_Load(object sender, EventArgs e)
        {
            headTimer.Start();
        }

        private void headTimer_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "left":
                    this.Left -= 10;
                    break;
                case "right":
                    this.Left += 10;
                    break;
                case "up":
                    this.Top -= 10;
                    break;
                case "down":
                    this.Top += 10;
                    break;
            }
            Share.snakePos[0][0] = this.Location.X;
            Share.snakePos[0][1] = this.Location.Y;
        }

        private void Head_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    direction = "right";
                    break;
                case Keys.Left:
                    direction = "left";
                    break;
                case Keys.Up:
                    direction
                    = "up";
                    break;
                case Keys.Down:
                    direction = "down";
                    break;
            }
        }
    }
}
