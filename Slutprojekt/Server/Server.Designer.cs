namespace Server
{
    partial class Server
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
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxActive = new System.Windows.Forms.ListBox();
            this.lblWelcUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxLog.Location = new System.Drawing.Point(182, 75);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(476, 394);
            this.tbxLog.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Users active:";
            // 
            // lbxActive
            // 
            this.lbxActive.BackColor = System.Drawing.Color.Black;
            this.lbxActive.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbxActive.FormattingEnabled = true;
            this.lbxActive.ItemHeight = 16;
            this.lbxActive.Location = new System.Drawing.Point(5, 75);
            this.lbxActive.Name = "lbxActive";
            this.lbxActive.Size = new System.Drawing.Size(159, 452);
            this.lbxActive.TabIndex = 36;
            // 
            // lblWelcUser
            // 
            this.lblWelcUser.AutoSize = true;
            this.lblWelcUser.BackColor = System.Drawing.Color.Teal;
            this.lblWelcUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcUser.Location = new System.Drawing.Point(377, 40);
            this.lblWelcUser.Name = "lblWelcUser";
            this.lblWelcUser.Size = new System.Drawing.Size(98, 32);
            this.lblWelcUser.TabIndex = 30;
            this.lblWelcUser.Text = "Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(170, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 494);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(306, 486);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(248, 28);
            this.btnStartServer.TabIndex = 41;
            this.btnStartServer.Text = "Start server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 28);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaSomToolStripMenuItem,
            this.sparaToolStripMenuItem1});
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sparaToolStripMenuItem.Text = "Spara";
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem1
            // 
            this.sparaToolStripMenuItem1.Name = "sparaToolStripMenuItem1";
            this.sparaToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.sparaToolStripMenuItem1.Text = "Spara";
            this.sparaToolStripMenuItem1.Click += new System.EventHandler(this.sparaToolStripMenuItem1_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(678, 535);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxActive);
            this.Controls.Add(this.lblWelcUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxActive;
        private System.Windows.Forms.Label lblWelcUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem1;
    }
}

