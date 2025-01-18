namespace formsSnake
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.title = new System.Windows.Forms.Label();
            this.goManual = new System.Windows.Forms.Button();
            this.goSetting = new System.Windows.Forms.Button();
            this.goStart = new System.Windows.Forms.Button();
            this.goExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(700, 100);
            this.title.TabIndex = 3;
            this.title.Text = "Form Snake";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goManual
            // 
            this.goManual.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goManual.Location = new System.Drawing.Point(103, 132);
            this.goManual.Name = "goManual";
            this.goManual.Size = new System.Drawing.Size(500, 100);
            this.goManual.TabIndex = 4;
            this.goManual.Text = "User Manual";
            this.goManual.UseVisualStyleBackColor = true;
            this.goManual.Click += new System.EventHandler(this.goManual_Click);
            // 
            // goSetting
            // 
            this.goSetting.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goSetting.Location = new System.Drawing.Point(102, 238);
            this.goSetting.Name = "goSetting";
            this.goSetting.Size = new System.Drawing.Size(500, 100);
            this.goSetting.TabIndex = 5;
            this.goSetting.Text = "Settings";
            this.goSetting.UseVisualStyleBackColor = true;
            this.goSetting.Click += new System.EventHandler(this.goSetting_Click);
            // 
            // goStart
            // 
            this.goStart.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goStart.Location = new System.Drawing.Point(103, 344);
            this.goStart.Name = "goStart";
            this.goStart.Size = new System.Drawing.Size(500, 100);
            this.goStart.TabIndex = 6;
            this.goStart.Text = "Play";
            this.goStart.UseVisualStyleBackColor = true;
            this.goStart.Click += new System.EventHandler(this.goStart_Click);
            // 
            // goExit
            // 
            this.goExit.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goExit.Location = new System.Drawing.Point(103, 450);
            this.goExit.Name = "goExit";
            this.goExit.Size = new System.Drawing.Size(500, 100);
            this.goExit.TabIndex = 7;
            this.goExit.Text = "Exit";
            this.goExit.UseVisualStyleBackColor = true;
            this.goExit.UseWaitCursor = true;
            this.goExit.Click += new System.EventHandler(this.goExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Built by the cutest kitty in the world";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goExit);
            this.Controls.Add(this.goStart);
            this.Controls.Add(this.goSetting);
            this.Controls.Add(this.goManual);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button goManual;
        private System.Windows.Forms.Button goSetting;
        private System.Windows.Forms.Button goStart;
        private System.Windows.Forms.Button goExit;
        private System.Windows.Forms.Label label1;
    }
}