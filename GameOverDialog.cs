using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class GameOverDialog : Form
    {
        public GameOverDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
