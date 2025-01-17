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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showLength_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showLength = showLength.Checked;
            Properties.Settings.Default.Save();
        }

        private void passThrough_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.passThrough = passThrough.Checked;
            Properties.Settings.Default.Save();
        }

        private void speed_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.speed = speed.Value;
            Properties.Settings.Default.Save();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            speed.Value = settings.speed;
            showLength.Checked = settings.showLength;
            passThrough.Checked = settings.passThrough;
        }
    }
}
