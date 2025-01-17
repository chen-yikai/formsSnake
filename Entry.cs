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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void goManual_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual();
            manual.Show();
        }

        private void goSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            setting.Width = this.Width;
            setting.Height = this.Height;
        }

        private void goExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goStart_Click(object sender, EventArgs e)
        {
            Root root = new Root();
            root.Show();
            this.Hide();
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            Share.playAgain += () =>
            {
                Root root = new Root();
                root = new Root();
                root.Show();
                this.Hide();
            };
        }
    }
}
