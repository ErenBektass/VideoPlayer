namespace PIXSelectBackendStajChallenge
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
            this.trackBarSesLvl = new System.Windows.Forms.TrackBar();
            this.trackBarVideoOynatma = new System.Windows.Forms.TrackBar();
            this.LblVolumeLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoHızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tmrVideoSure = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSesLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoOynatma)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarSesLvl
            // 
            this.trackBarSesLvl.Location = new System.Drawing.Point(540, 478);
            this.trackBarSesLvl.Maximum = 100;
            this.trackBarSesLvl.Name = "trackBarSesLvl";
            this.trackBarSesLvl.Size = new System.Drawing.Size(129, 45);
            this.trackBarSesLvl.TabIndex = 7;
            this.trackBarSesLvl.Value = 60;
            this.trackBarSesLvl.ValueChanged += new System.EventHandler(this.trackBarSesLvl_ValueChanged);
            // 
            // trackBarVideoOynatma
            // 
            this.trackBarVideoOynatma.Location = new System.Drawing.Point(12, 427);
            this.trackBarVideoOynatma.Maximum = 100;
            this.trackBarVideoOynatma.Minimum = 1;
            this.trackBarVideoOynatma.Name = "trackBarVideoOynatma";
            this.trackBarVideoOynatma.Size = new System.Drawing.Size(544, 45);
            this.trackBarVideoOynatma.TabIndex = 8;
            this.trackBarVideoOynatma.Value = 1;
            this.trackBarVideoOynatma.Scroll += new System.EventHandler(this.trackBarVideoOynatma_Scroll);
            // 
            // LblVolumeLevel
            // 
            this.LblVolumeLevel.AutoSize = true;
            this.LblVolumeLevel.Location = new System.Drawing.Point(464, 479);
            this.LblVolumeLevel.Name = "LblVolumeLevel";
            this.LblVolumeLevel.Size = new System.Drawing.Size(70, 13);
            this.LblVolumeLevel.TabIndex = 12;
            this.LblVolumeLevel.Text = "Ses Seviyesi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Video Oynatma";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.videoHızToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaEkleToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // dosyaEkleToolStripMenuItem
            // 
            this.dosyaEkleToolStripMenuItem.Name = "dosyaEkleToolStripMenuItem";
            this.dosyaEkleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.dosyaEkleToolStripMenuItem.Text = "Dosya Ekle";
            this.dosyaEkleToolStripMenuItem.Click += new System.EventHandler(this.dosyaEkleToolStripMenuItem_Click);
            // 
            // videoHızToolStripMenuItem
            // 
            this.videoHızToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2});
            this.videoHızToolStripMenuItem.Name = "videoHızToolStripMenuItem";
            this.videoHızToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.videoHızToolStripMenuItem.Text = "Video Hız";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.xToolStripMenuItem.Text = "1x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.xToolStripMenuItem1.Text = "2x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.xToolStripMenuItem2.Text = "3x";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(12, 478);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(63, 52);
            this.btnIleri.TabIndex = 17;
            this.btnIleri.Text = "İleri Sar";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(286, 479);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(62, 51);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri Sar";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tmrVideoSure
            // 
            this.tmrVideoSure.Interval = 500;
            this.tmrVideoSure.Tick += new System.EventHandler(this.tmrVideoSure_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(587, 427);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 16);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "--:--";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(144, 479);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(63, 51);
            this.btnDurdur.TabIndex = 21;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 381);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVolumeLevel);
            this.Controls.Add(this.trackBarVideoOynatma);
            this.Controls.Add(this.trackBarSesLvl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Video Oynatıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSesLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoOynatma)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TrackBar trackBarSesLvl;
		private System.Windows.Forms.TrackBar trackBarVideoOynatma;
		private System.Windows.Forms.Label LblVolumeLevel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dosyaEkleToolStripMenuItem;
		private System.Windows.Forms.Button btnIleri;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.ToolStripMenuItem videoHızToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
		private System.Windows.Forms.Timer tmrVideoSure;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Button btnDurdur;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Panel panel1;
    }
}

