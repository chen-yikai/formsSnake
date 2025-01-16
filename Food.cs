using System;
using System.Drawing;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Red;
            this.Width = Share.moveLength;
            this.Height = Share.moveLength;
            this.TopMost = true;
            int x, y;
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            while (true)
            {
                Random random = new Random();
                x = random.Next(0, 20) * Share.moveLength;
                y = random.Next(0, 10) * Share.moveLength;
                if (x + this.Width <= screen.Width && y + this.Height <= screen.Height)
                {
                    var overBody = false;
                    foreach (var body in Share.snakePos)
                    {
                        if (body.x == x && body.y == y)
                        {
                            overBody = true;
                            break;
                        }
                    }
                    if (overBody)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }
            this.Location = new Point(x, y);
        }
    }
}
