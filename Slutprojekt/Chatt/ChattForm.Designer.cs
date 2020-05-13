namespace Chatt
{
    partial class ChattForm
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
            this.lblWelcUser = new System.Windows.Forms.Label();
            this.tbxTypeBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestOf3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestOf6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.besOf9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lbxActive = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxChatt = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcUser
            // 
            this.lblWelcUser.AutoSize = true;
            this.lblWelcUser.BackColor = System.Drawing.Color.Teal;
            this.lblWelcUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcUser.Location = new System.Drawing.Point(271, 123);
            this.lblWelcUser.Name = "lblWelcUser";
            this.lblWelcUser.Size = new System.Drawing.Size(286, 32);
            this.lblWelcUser.TabIndex = 3;
            this.lblWelcUser.Text = "Welcome [Username]";
            // 
            // tbxTypeBox
            // 
            this.tbxTypeBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxTypeBox.Location = new System.Drawing.Point(182, 488);
            this.tbxTypeBox.Multiline = true;
            this.tbxTypeBox.Name = "tbxTypeBox";
            this.tbxTypeBox.Size = new System.Drawing.Size(398, 52);
            this.tbxTypeBox.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.ForeColor = System.Drawing.Color.Yellow;
            this.btnSend.Location = new System.Drawing.Point(596, 493);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 39);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(170, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 515);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestOf3ToolStripMenuItem,
            this.bestOf6ToolStripMenuItem,
            this.besOf9ToolStripMenuItem});
            this.startGameToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.startGameToolStripMenuItem.Text = "Start a Game";
            // 
            // bestOf3ToolStripMenuItem
            // 
            this.bestOf3ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.bestOf3ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.bestOf3ToolStripMenuItem.Name = "bestOf3ToolStripMenuItem";
            this.bestOf3ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.bestOf3ToolStripMenuItem.Text = "Best of 3";
            // 
            // bestOf6ToolStripMenuItem
            // 
            this.bestOf6ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.bestOf6ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.bestOf6ToolStripMenuItem.Name = "bestOf6ToolStripMenuItem";
            this.bestOf6ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.bestOf6ToolStripMenuItem.Text = "Best of 6";
            // 
            // besOf9ToolStripMenuItem
            // 
            this.besOf9ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.besOf9ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.besOf9ToolStripMenuItem.Name = "besOf9ToolStripMenuItem";
            this.besOf9ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.besOf9ToolStripMenuItem.Text = "Best of 9";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Yellow;
            this.btnCloseForm.Location = new System.Drawing.Point(656, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(28, 23);
            this.btnCloseForm.TabIndex = 26;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lbxActive
            // 
            this.lbxActive.BackColor = System.Drawing.Color.Black;
            this.lbxActive.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbxActive.FormattingEnabled = true;
            this.lbxActive.ItemHeight = 16;
            this.lbxActive.Location = new System.Drawing.Point(5, 68);
            this.lbxActive.Name = "lbxActive";
            this.lbxActive.Size = new System.Drawing.Size(159, 484);
            this.lbxActive.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Users active:";
            // 
            // tbxChatt
            // 
            this.tbxChatt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxChatt.Location = new System.Drawing.Point(182, 158);
            this.tbxChatt.Multiline = true;
            this.tbxChatt.Name = "tbxChatt";
            this.tbxChatt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxChatt.Size = new System.Drawing.Size(476, 324);
            this.tbxChatt.TabIndex = 29;
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(353, 68);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(71, 22);
            this.tbxIP.TabIndex = 30;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(442, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 31;
            this.btnConnect.Text = "anslut";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ChattForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(685, 559);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.tbxChatt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxActive);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxTypeBox);
            this.Controls.Add(this.lblWelcUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChattForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChattForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcUser;
        private System.Windows.Forms.TextBox tbxTypeBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ToolStripMenuItem bestOf3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestOf6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem besOf9ToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxChatt;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Button btnConnect;
    }
}

