namespace Test_for_Gabrovec
{
    partial class osnovanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osnovanie));
            this.name_panel = new System.Windows.Forms.Panel();
            this.name_pb = new System.Windows.Forms.PictureBox();
            this.content_game_panel = new System.Windows.Forms.Panel();
            this.gabrovec = new System.Windows.Forms.PictureBox();
            this.name_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name_pb)).BeginInit();
            this.content_game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gabrovec)).BeginInit();
            this.SuspendLayout();
            // 
            // name_panel
            // 
            this.name_panel.Controls.Add(this.name_pb);
            this.name_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_panel.Location = new System.Drawing.Point(0, 0);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(1182, 119);
            this.name_panel.TabIndex = 0;
            // 
            // name_pb
            // 
            this.name_pb.Image = ((System.Drawing.Image)(resources.GetObject("name_pb.Image")));
            this.name_pb.Location = new System.Drawing.Point(331, 0);
            this.name_pb.Name = "name_pb";
            this.name_pb.Size = new System.Drawing.Size(548, 139);
            this.name_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.name_pb.TabIndex = 0;
            this.name_pb.TabStop = false;
            // 
            // content_game_panel
            // 
            this.content_game_panel.Controls.Add(this.gabrovec);
            this.content_game_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.content_game_panel.Location = new System.Drawing.Point(0, 161);
            this.content_game_panel.Name = "content_game_panel";
            this.content_game_panel.Size = new System.Drawing.Size(1182, 542);
            this.content_game_panel.TabIndex = 2;
            // 
            // gabrovec
            // 
            this.gabrovec.Image = ((System.Drawing.Image)(resources.GetObject("gabrovec.Image")));
            this.gabrovec.Location = new System.Drawing.Point(540, 389);
            this.gabrovec.Name = "gabrovec";
            this.gabrovec.Size = new System.Drawing.Size(79, 153);
            this.gabrovec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gabrovec.TabIndex = 0;
            this.gabrovec.TabStop = false;
            // 
            // osnovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.content_game_panel);
            this.Controls.Add(this.name_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "osnovanie";
            this.Text = "Основание";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.osnovanie_KeyDown);
            this.name_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.name_pb)).EndInit();
            this.content_game_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gabrovec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel name_panel;
        private PictureBox name_pb;
        private Panel content_game_panel;
        private PictureBox gabrovec;
    }
}