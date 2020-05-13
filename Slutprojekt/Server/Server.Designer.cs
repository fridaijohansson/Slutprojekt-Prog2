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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxGameList = new System.Windows.Forms.ListBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxLog.Location = new System.Drawing.Point(182, 55);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(476, 414);
            this.tbxLog.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(22, 14);
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
            this.lbxActive.Location = new System.Drawing.Point(5, 43);
            this.lbxActive.Name = "lbxActive";
            this.lbxActive.Size = new System.Drawing.Size(159, 484);
            this.lbxActive.TabIndex = 36;
            // 
            // lblWelcUser
            // 
            this.lblWelcUser.AutoSize = true;
            this.lblWelcUser.BackColor = System.Drawing.Color.Teal;
            this.lblWelcUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcUser.Location = new System.Drawing.Point(365, 20);
            this.lblWelcUser.Name = "lblWelcUser";
            this.lblWelcUser.Size = new System.Drawing.Size(98, 32);
            this.lblWelcUser.TabIndex = 30;
            this.lblWelcUser.Text = "Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 515);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(696, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Users in game:";
            // 
            // lbxGameList
            // 
            this.lbxGameList.BackColor = System.Drawing.Color.Black;
            this.lbxGameList.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbxGameList.FormattingEnabled = true;
            this.lbxGameList.ItemHeight = 16;
            this.lbxGameList.Location = new System.Drawing.Point(679, 43);
            this.lbxGameList.Name = "lbxGameList";
            this.lbxGameList.Size = new System.Drawing.Size(159, 484);
            this.lbxGameList.TabIndex = 39;
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
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 535);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxGameList);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxActive);
            this.Controls.Add(this.lblWelcUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxActive;
        private System.Windows.Forms.Label lblWelcUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxGameList;
        private System.Windows.Forms.Button btnStartServer;
    }
}

