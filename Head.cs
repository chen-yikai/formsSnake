using System;
using System.Drawing;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class Head : Form
    {
        public string direction = "";
        Food food = new Food();
        public Head()
        {
            InitializeComponent();
        }

        private void Head_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = Share.moveLength;
            this.Height = Share.moveLength;
            this.Location = new Point(0, 0);
            this.TopMost = true;
            headTimer.Interval = Share.moveSpeed;
            headTimer.Start();
            food.Show();
            this.Focus();
        }
        private void headTimer_Tick(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            switch (direction)
            {
                case "left":
                    this.Left -= Share.moveLength;
                    break;
                case "right":
                    this.Left += Share.moveLength;
                    break;
                case "up":
                    this.Top -= Share.moveLength;
                    break;
                case "down":
                    this.Top += Share.moveLength;
                    break;
            }
            formsSnake.Share.setPos(0, this.Location.X, this.Location.Y);
            if (this.Bounds.IntersectsWith(food.Bounds))
            {
                food.Hide();
                food = new Food();
                food.Show();
                this.Focus();
                formsSnake.Share.bodyLength++;
            }
            if (this.Location.X < 0 || this.Location.Y < 0 || this.Location.X > screen.Width || this.Location.Y > screen.Height)
            {
                headTimer.Stop();
                Share.GameOver();
            }
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
                    direction = "up";
                    break;
                case Keys.Down:
                    direction = "down";
                    break;
                case Keys.Q:
                    Share.GameOver();
                    break;
            }
        }
    }
}
