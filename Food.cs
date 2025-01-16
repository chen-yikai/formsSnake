using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
                    break;
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
