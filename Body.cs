using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;

namespace formsSnake
{
    public partial class Body : Form
    {
        private int index = 0;
        public Body(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void Body_Load(object sender, System.EventArgs e)
        {
            this.Location = new Point(-Share.moveLength, -Share.moveLength);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Height = Share.moveLength;
            this.Width = Share.moveLength;
            this.BackColor = Color.LightPink;
            Label indexShow = new Label();
            indexShow.Font = new Font("Arial", 30, FontStyle.Bold);
            indexShow.Location = new Point(0, 0);
            indexShow.AutoSize = false;
            indexShow.Width = this.Width;
            indexShow.Height = this.Height;
            indexShow.TextAlign = ContentAlignment.MiddleCenter;
            //indexShow.Text = index.ToString();
            indexShow.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(indexShow);

            Share.SnakeMove += () =>
            {
                var thisIndex = Share.snakePos.Count - index;
                var headIndex = Share.snakePos.Count - 1;
                if (this.Bounds.IntersectsWith(new Rectangle(Share.snakePos[headIndex].x, Share.snakePos[headIndex].y, 1, 1)))
                {
                    Share.GameOver();
                }
                else
                {
                    this.Location = new Point(Share.snakePos[thisIndex].x, Share.snakePos[thisIndex].y);
                }

            };
        }
    }
}