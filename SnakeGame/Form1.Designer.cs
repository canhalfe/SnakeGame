﻿namespace SnakeGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.saha = new System.Windows.Forms.Panel();
            this.cmsSaha = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seviyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKolay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSkorlar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOyunBitti = new System.Windows.Forms.Label();
            this.lblDurdu = new System.Windows.Forms.Label();
            this.lblAcıklama = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPuan = new System.Windows.Forms.Label();
            this.pnlGiris = new MetroFramework.Controls.MetroPanel();
            this.btnOyunuBaslat = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOyuncu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.saha.SuspendLayout();
            this.cmsSaha.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saha
            // 
            this.saha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saha.ContextMenuStrip = this.cmsSaha;
            this.saha.Controls.Add(this.lblDurdu);
            this.saha.Controls.Add(this.lblAcıklama);
            this.saha.Controls.Add(this.lblOyunBitti);
            this.saha.Location = new System.Drawing.Point(23, 63);
            this.saha.Name = "saha";
            this.saha.Size = new System.Drawing.Size(400, 400);
            this.saha.TabIndex = 0;
            this.saha.Paint += new System.Windows.Forms.PaintEventHandler(this.saha_Paint);
            // 
            // cmsSaha
            // 
            this.cmsSaha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seviyeToolStripMenuItem,
            this.tsmiSkorlar});
            this.cmsSaha.Name = "cmsSaha";
            this.cmsSaha.Size = new System.Drawing.Size(111, 48);
            // 
            // seviyeToolStripMenuItem
            // 
            this.seviyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKolay,
            this.tsmiZor});
            this.seviyeToolStripMenuItem.Name = "seviyeToolStripMenuItem";
            this.seviyeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.seviyeToolStripMenuItem.Text = "Seviye";
            // 
            // tsmiKolay
            // 
            this.tsmiKolay.Name = "tsmiKolay";
            this.tsmiKolay.Size = new System.Drawing.Size(103, 22);
            this.tsmiKolay.Text = "Kolay";
            this.tsmiKolay.Click += new System.EventHandler(this.tsmiKolay_Click);
            // 
            // tsmiZor
            // 
            this.tsmiZor.Checked = true;
            this.tsmiZor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiZor.Name = "tsmiZor";
            this.tsmiZor.Size = new System.Drawing.Size(103, 22);
            this.tsmiZor.Text = "Zor";
            this.tsmiZor.Click += new System.EventHandler(this.tsmiZor_Click);
            // 
            // tsmiSkorlar
            // 
            this.tsmiSkorlar.Name = "tsmiSkorlar";
            this.tsmiSkorlar.Size = new System.Drawing.Size(110, 22);
            this.tsmiSkorlar.Text = "Skorlar";
            this.tsmiSkorlar.Click += new System.EventHandler(this.tsmiSkorlar_Click);
            // 
            // lblOyunBitti
            // 
            this.lblOyunBitti.BackColor = System.Drawing.Color.Transparent;
            this.lblOyunBitti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunBitti.ForeColor = System.Drawing.Color.Maroon;
            this.lblOyunBitti.Location = new System.Drawing.Point(22, 126);
            this.lblOyunBitti.Name = "lblOyunBitti";
            this.lblOyunBitti.Size = new System.Drawing.Size(357, 108);
            this.lblOyunBitti.TabIndex = 2;
            this.lblOyunBitti.Text = "OYUN BİTTİ!\r\nYENİ OYUN İÇİN F2\'YE BASINIZ\r\n\r\n\r\n\r\n";
            this.lblOyunBitti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOyunBitti.Visible = false;
            // 
            // lblDurdu
            // 
            this.lblDurdu.BackColor = System.Drawing.Color.Transparent;
            this.lblDurdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurdu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDurdu.Location = new System.Drawing.Point(22, 256);
            this.lblDurdu.Name = "lblDurdu";
            this.lblDurdu.Size = new System.Drawing.Size(357, 46);
            this.lblDurdu.TabIndex = 1;
            this.lblDurdu.Text = "OYUN DURAKLATILDI.\r\n(Devam için F2)\r\n\r\n\r\n";
            this.lblDurdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDurdu.Visible = false;
            this.lblDurdu.Click += new System.EventHandler(this.lblDurdu_Click);
            // 
            // lblAcıklama
            // 
            this.lblAcıklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcıklama.ForeColor = System.Drawing.Color.Green;
            this.lblAcıklama.Location = new System.Drawing.Point(22, 313);
            this.lblAcıklama.Name = "lblAcıklama";
            this.lblAcıklama.Size = new System.Drawing.Size(357, 87);
            this.lblAcıklama.TabIndex = 0;
            this.lblAcıklama.Text = "Oyuna başlamak/durdurmak için F2 tuşuna basınız.\r\n\r\nYılanı hareket ettirmek için " +
    "yön tuşlarını(→, ←, ↑,↓) kullanınız.\r\n\r\n\r\n";
            this.lblAcıklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Black;
            this.lblPuan.Location = new System.Drawing.Point(350, 34);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(74, 26);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "000\r\n\r\n\r\n\r\n\r\n";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.btnOyunuBaslat);
            this.pnlGiris.Controls.Add(this.pictureBox1);
            this.pnlGiris.Controls.Add(this.txtOyuncu);
            this.pnlGiris.Controls.Add(this.metroLabel1);
            this.pnlGiris.HorizontalScrollbarBarColor = true;
            this.pnlGiris.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGiris.HorizontalScrollbarSize = 10;
            this.pnlGiris.Location = new System.Drawing.Point(23, 63);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(400, 400);
            this.pnlGiris.TabIndex = 4;
            this.pnlGiris.VerticalScrollbarBarColor = true;
            this.pnlGiris.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGiris.VerticalScrollbarSize = 10;
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(112, 195);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(147, 39);
            this.btnOyunuBaslat.TabIndex = 5;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.UseSelectable = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SnakeGame.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(112, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 88);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtOyuncu
            // 
            // 
            // 
            // 
            this.txtOyuncu.CustomButton.Image = null;
            this.txtOyuncu.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtOyuncu.CustomButton.Name = "";
            this.txtOyuncu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOyuncu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOyuncu.CustomButton.TabIndex = 1;
            this.txtOyuncu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOyuncu.CustomButton.UseSelectable = true;
            this.txtOyuncu.CustomButton.Visible = false;
            this.txtOyuncu.Lines = new string[0];
            this.txtOyuncu.Location = new System.Drawing.Point(112, 166);
            this.txtOyuncu.MaxLength = 32767;
            this.txtOyuncu.Name = "txtOyuncu";
            this.txtOyuncu.PasswordChar = '\0';
            this.txtOyuncu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOyuncu.SelectedText = "";
            this.txtOyuncu.SelectionLength = 0;
            this.txtOyuncu.SelectionStart = 0;
            this.txtOyuncu.ShortcutsEnabled = true;
            this.txtOyuncu.Size = new System.Drawing.Size(75, 23);
            this.txtOyuncu.TabIndex = 3;
            this.txtOyuncu.UseSelectable = true;
            this.txtOyuncu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOyuncu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOyuncu.Click += new System.EventHandler(this.txtOyuncu_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(112, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 38);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Adınız:\r\n";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOyunuBaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 483);
            this.ContextMenuStrip = this.cmsSaha;
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.saha);
            this.Name = "Form1";
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.saha.ResumeLayout(false);
            this.cmsSaha.ResumeLayout(false);
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel saha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAcıklama;
        private System.Windows.Forms.Label lblDurdu;
        private System.Windows.Forms.Label lblOyunBitti;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.ContextMenuStrip cmsSaha;
        private System.Windows.Forms.ToolStripMenuItem seviyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKolay;
        private System.Windows.Forms.ToolStripMenuItem tsmiZor;
        private System.Windows.Forms.ToolStripMenuItem tsmiSkorlar;
        private MetroFramework.Controls.MetroPanel pnlGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtOyuncu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnOyunuBaslat;
    }
}

