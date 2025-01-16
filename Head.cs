using System;
using System.Drawing;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class Head : Form
    {
        public string direction = "right";
        Food food = new Food();
        Label indexShow = new Label();
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

            indexShow.Font = new Font("Arial", 20, FontStyle.Bold);
            indexShow.Location = new Point(0, 0);
            indexShow.AutoSize = false;
            indexShow.Width = this.Width;
            indexShow.Height = this.Height;
            indexShow.TextAlign = ContentAlignment.MiddleCenter;
            indexShow.Text = "";
            indexShow.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(indexShow);
            this.BackColor = Color.LightGreen;
            headTimer.Interval = Share.moveSpeed;
            headTimer.Start();
            food.Show();
            this.Focus();

            Share.gameOvered += () =>
            {
                headTimer.Stop();
            };

        }
        private void headTimer_Tick(object sender, EventArgs e)
        {
            Share.setPos(this.Location.X, this.Location.Y);

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
            if (this.Bounds.IntersectsWith(food.Bounds))
            {
                food.Hide();
                food = new Food();
                food.Show();
                Share.bodyLength++;
                this.Focus();
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
                case Keys.P:
                    if (headTimer.Enabled)
                    {
                        indexShow.Text = "Pause";
                        headTimer.Stop();
                    }
                    else
                    {
                        indexShow.Text = "";
                        headTimer.Start();
                    }
                    break;
            }
        }

        private void Head_Shown(object sender, EventArgs e)
        {
            headTimer.Start();
            indexShow.Text = "";
            this.Focus();
            this.Deactivate += Head_deactivate;
        }

        private void Head_deactivate(object sender, EventArgs e)
        {
            headTimer.Stop();
            indexShow.Text = "Pause";
            this.Activated += Head_activated;
        }
        private void Head_activated(object sender, EventArgs e)
        {
            headTimer.Start();
            indexShow.Text = "";
            this.Activated -= Head_activated;
        }
    }
}
