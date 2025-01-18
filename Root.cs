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
            this.IsMdiContainer = true;
            this.BackColor = Color.LightSkyBlue;
            this.Width = 150;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            if (Properties.Settings.Default.showLength)
            {
                this.Location = new Point(screen.Width - this.Width, screen.Height - this.Height);
            }
            else
            {
                this.Location = new Point(-this.Width, -this.Height);
            }

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

                Body body = new Body(Share.bodyLength);
                body.Show();
            };
            Share.gameOvered += () =>
            {
                GameOverDialog gameOverDialog = new GameOverDialog();
                gameOverDialog.Show();
            };
            Head head = new Head();
            head.Show();
        }
    }
}