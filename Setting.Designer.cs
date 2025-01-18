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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
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
            this.showLength.Location = new System.Drawing.Point(114, 98);
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
            this.speed.Location = new System.Drawing.Point(234, 350);
            this.speed.Maximum = 600;
            this.speed.Minimum = 50;
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
            this.label1.Location = new System.Drawing.Point(107, 350);
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
            this.label2.Location = new System.Drawing.Point(546, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Slow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fast";
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(97, 519);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(512, 71);
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
            this.passThrough.Location = new System.Drawing.Point(114, 178);
            this.passThrough.Name = "passThrough";
            this.passThrough.Size = new System.Drawing.Size(361, 42);
            this.passThrough.TabIndex = 11;
            this.passThrough.Text = "Pass through screen";
            this.passThrough.UseVisualStyleBackColor = true;
            this.passThrough.CheckedChanged += new System.EventHandler(this.passThrough_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Small";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Big";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Size";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // size
            // 
            this.size.LargeChange = 50;
            this.size.Location = new System.Drawing.Point(234, 257);
            this.size.Maximum = 400;
            this.size.Minimum = 10;
            this.size.Name = "size";
            this.size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.size.Size = new System.Drawing.Size(348, 56);
            this.size.SmallChange = 10;
            this.size.TabIndex = 12;
            this.size.TabStop = false;
            this.size.TickFrequency = 10;
            this.size.Value = 100;
            this.size.Scroll += new System.EventHandler(this.size_Scroll);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 71);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.size);
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
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar size;
        private System.Windows.Forms.Button button1;
    }
}