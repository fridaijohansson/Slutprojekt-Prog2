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
            this.lbxActive = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxChatt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcUser
            // 
            this.lblWelcUser.AutoSize = true;
            this.lblWelcUser.BackColor = System.Drawing.Color.Teal;
            this.lblWelcUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcUser.Location = new System.Drawing.Point(294, 14);
            this.lblWelcUser.Name = "lblWelcUser";
            this.lblWelcUser.Size = new System.Drawing.Size(286, 32);
            this.lblWelcUser.TabIndex = 3;
            this.lblWelcUser.Text = "Welcome [Username]";
            // 
            // tbxTypeBox
            // 
            this.tbxTypeBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxTypeBox.Location = new System.Drawing.Point(182, 463);
            this.tbxTypeBox.Multiline = true;
            this.tbxTypeBox.Name = "tbxTypeBox";
            this.tbxTypeBox.Size = new System.Drawing.Size(398, 52);
            this.tbxTypeBox.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.ForeColor = System.Drawing.Color.Yellow;
            this.btnSend.Location = new System.Drawing.Point(596, 468);
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
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 515);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            this.lbxActive.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Users active:";
            // 
            // tbxChatt
            // 
            this.tbxChatt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxChatt.Location = new System.Drawing.Point(182, 49);
            this.tbxChatt.Multiline = true;
            this.tbxChatt.Name = "tbxChatt";
            this.tbxChatt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxChatt.Size = new System.Drawing.Size(476, 408);
            this.tbxChatt.TabIndex = 29;
            // 
            // ChattForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(685, 532);
            this.Controls.Add(this.tbxChatt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxActive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxTypeBox);
            this.Controls.Add(this.lblWelcUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChattForm";
            this.Text = "ChattForm";
            this.Load += new System.EventHandler(this.ChattForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcUser;
        private System.Windows.Forms.TextBox tbxTypeBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxChatt;
    }
}

