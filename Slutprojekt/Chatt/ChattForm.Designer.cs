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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.bestOf3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestOf6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.besOf9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(267, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome [Username]";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Location = new System.Drawing.Point(182, 488);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 52);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(596, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // bestOf3ToolStripMenuItem
            // 
            this.bestOf3ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.bestOf3ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.bestOf3ToolStripMenuItem.Name = "bestOf3ToolStripMenuItem";
            this.bestOf3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bestOf3ToolStripMenuItem.Text = "Best of 3";
            // 
            // bestOf6ToolStripMenuItem
            // 
            this.bestOf6ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.bestOf6ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.bestOf6ToolStripMenuItem.Name = "bestOf6ToolStripMenuItem";
            this.bestOf6ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bestOf6ToolStripMenuItem.Text = "Best of 6";
            // 
            // besOf9ToolStripMenuItem
            // 
            this.besOf9ToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.besOf9ToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.besOf9ToolStripMenuItem.Name = "besOf9ToolStripMenuItem";
            this.besOf9ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.besOf9ToolStripMenuItem.Text = "Best of 9";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(5, 68);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(159, 484);
            this.listBox2.TabIndex = 27;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.Location = new System.Drawing.Point(182, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(476, 402);
            this.textBox2.TabIndex = 29;
            // 
            // ChattForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(685, 559);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChattForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ToolStripMenuItem bestOf3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestOf6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem besOf9ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

