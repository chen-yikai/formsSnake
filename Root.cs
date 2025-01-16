using System;
using System.Drawing;
using System.Windows.Forms;

namespace formsSnake
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Head head = new Head();
            head.Show();

            this.BackColor = Color.MediumPurple;
            this.Width = 200;
            this.Height = 200;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(screen.Width - this.Width, screen.Height - this.Height);

            Label length = new Label();
            length.Font = new Font("Arial", 30, FontStyle.Bold);
            length.Location = new Point(0, 0);
            length.AutoSize = false;
            length.Width = this.Width;
            length.Height = this.Height;
            length.TextAlign = ContentAlignment.MiddleCenter;
            length.Text = "0";
            this.Controls.Add(length);

            Share.lengthChange += () =>
            {
                length.Text = Share.bodyLength.ToString();
            };
            Share.gameOvered += () =>
            {
                var result = MessageBox.Show("<Game Over> QQ", "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                if (result == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }

                Application.Exit();
            };
        }
    }
}