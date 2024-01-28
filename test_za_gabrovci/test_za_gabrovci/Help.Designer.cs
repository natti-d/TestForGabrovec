namespace test_za_gabrovci
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.name_panel = new System.Windows.Forms.Panel();
            this.help_lbl = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.blackcat_picbox1 = new System.Windows.Forms.PictureBox();
            this.name_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackcat_picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_panel
            // 
            this.name_panel.Controls.Add(this.help_lbl);
            this.name_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_panel.Location = new System.Drawing.Point(0, 0);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(1182, 119);
            this.name_panel.TabIndex = 2;
            // 
            // help_lbl
            // 
            this.help_lbl.AutoSize = true;
            this.help_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(221)))), ((int)(((byte)(158)))));
            this.help_lbl.Location = new System.Drawing.Point(381, 12);
            this.help_lbl.Name = "help_lbl";
            this.help_lbl.Size = new System.Drawing.Size(420, 95);
            this.help_lbl.TabIndex = 0;
            this.help_lbl.Text = "За играта";
            this.help_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(221)))), ((int)(((byte)(158)))));
            this.info_lbl.Location = new System.Drawing.Point(196, 149);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(796, 429);
            this.info_lbl.TabIndex = 3;
            this.info_lbl.Text = resources.GetString("info_lbl.Text");
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::test_za_gabrovci.Properties.Resources.blackcat2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // blackcat_picbox1
            // 
            this.blackcat_picbox1.BackColor = System.Drawing.Color.Transparent;
            this.blackcat_picbox1.Image = global::test_za_gabrovci.Properties.Resources.blackcat1;
            this.blackcat_picbox1.Location = new System.Drawing.Point(924, 425);
            this.blackcat_picbox1.Name = "blackcat_picbox1";
            this.blackcat_picbox1.Size = new System.Drawing.Size(301, 283);
            this.blackcat_picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackcat_picbox1.TabIndex = 4;
            this.blackcat_picbox1.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.blackcat_picbox1);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.name_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Help";
            this.Text = "За играта";
            this.name_panel.ResumeLayout(false);
            this.name_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackcat_picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel name_panel;
        private System.Windows.Forms.Label help_lbl;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.PictureBox blackcat_picbox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}