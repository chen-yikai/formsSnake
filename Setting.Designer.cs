namespace formsSnake
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.showLength = new System.Windows.Forms.CheckBox();
            this.speed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoBack = new System.Windows.Forms.Button();
            this.passThrough = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(700, 100);
            this.title.TabIndex = 4;
            this.title.Text = "Settings";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showLength
            // 
            this.showLength.AutoSize = true;
            this.showLength.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLength.Location = new System.Drawing.Point(114, 150);
            this.showLength.Name = "showLength";
            this.showLength.Size = new System.Drawing.Size(456, 42);
            this.showLength.TabIndex = 5;
            this.showLength.Text = "Show current snake length";
            this.showLength.UseVisualStyleBackColor = true;
            this.showLength.CheckedChanged += new System.EventHandler(this.showLength_CheckedChanged);
            // 
            // speed
            // 
            this.speed.LargeChange = 50;
            this.speed.Location = new System.Drawing.Point(234, 355);
            this.speed.Maximum = 600;
            this.speed.Minimum = 100;
            this.speed.Name = "speed";
            this.speed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speed.Size = new System.Drawing.Size(348, 56);
            this.speed.SmallChange = 50;
            this.speed.TabIndex = 6;
            this.speed.TickFrequency = 50;
            this.speed.Value = 400;
            this.speed.Scroll += new System.EventHandler(this.speed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Slow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fast";
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(97, 488);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(512, 100);
            this.GoBack.TabIndex = 10;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.UseWaitCursor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // passThrough
            // 
            this.passThrough.AutoSize = true;
            this.passThrough.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passThrough.Location = new System.Drawing.Point(114, 247);
            this.passThrough.Name = "passThrough";
            this.passThrough.Size = new System.Drawing.Size(361, 42);
            this.passThrough.TabIndex = 11;
            this.passThrough.Text = "Pass through screen";
            this.passThrough.UseVisualStyleBackColor = true;
            this.passThrough.CheckedChanged += new System.EventHandler(this.passThrough_CheckedChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.passThrough);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.showLength);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox showLength;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.CheckBox passThrough;
    }
}