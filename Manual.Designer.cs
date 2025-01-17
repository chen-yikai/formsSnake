namespace formsSnake
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.title = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial Black", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(700, 100);
            this.title.TabIndex = 2;
            this.title.Text = "User Manual";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(0, 100);
            this.content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.content.Name = "content";
            this.content.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.content.Size = new System.Drawing.Size(700, 359);
            this.content.TabIndex = 3;
            this.content.Text = resources.GetString("content.Text");
            // 
            // hide
            // 
            this.hide.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide.Location = new System.Drawing.Point(98, 488);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(500, 100);
            this.hide.TabIndex = 8;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.UseWaitCursor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.content);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Button hide;
    }
}