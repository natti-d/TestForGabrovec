namespace Test_for_Gabrovec
{
    partial class home_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.igrai_btn = new System.Windows.Forms.Button();
            this.pomosht_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // igrai_btn
            // 
            this.igrai_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.igrai_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.igrai_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igrai_btn.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.igrai_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(221)))), ((int)(((byte)(158)))));
            this.igrai_btn.Location = new System.Drawing.Point(508, 337);
            this.igrai_btn.Name = "igrai_btn";
            this.igrai_btn.Size = new System.Drawing.Size(180, 81);
            this.igrai_btn.TabIndex = 2;
            this.igrai_btn.Text = "Играй";
            this.igrai_btn.UseVisualStyleBackColor = false;
            this.igrai_btn.Click += new System.EventHandler(this.igrai_btn_Click);
            // 
            // pomosht_btn
            // 
            this.pomosht_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.pomosht_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pomosht_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pomosht_btn.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pomosht_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(221)))), ((int)(((byte)(158)))));
            this.pomosht_btn.Location = new System.Drawing.Point(508, 434);
            this.pomosht_btn.Name = "pomosht_btn";
            this.pomosht_btn.Size = new System.Drawing.Size(180, 81);
            this.pomosht_btn.TabIndex = 3;
            this.pomosht_btn.Text = "Помощ";
            this.pomosht_btn.UseVisualStyleBackColor = false;
            this.pomosht_btn.Click += new System.EventHandler(this.pomosht_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 119);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1164, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pomosht_btn);
            this.Controls.Add(this.igrai_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "home_page";
            this.Text = "Тест за скъперници";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button igrai_btn;
        private Button pomosht_btn;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}