using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PIXSelectBackendStajChallenge
{
	public partial class Form1 : Form
	{
     
        public Form1()
		{
            vlcControl1 = new VlcControl();
            InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
            vlcControl1.BeginInit();
            vlcControl1.VlcLibDirectory = new DirectoryInfo(@".\libvlc\win-x86"); //Make sure your dir is correct
            vlcControl1.VlcMediaplayerOptions = new[] { "-vv" }; //not sure what this does
            vlcControl1.EndInit();
            panel1.Controls.Add(vlcControl1); //Add the control to your container
            vlcControl1.Dock = DockStyle.Fill;
            //this.vlcControl1.Click += new EventHandler(vlcControl1_Click); //Optional - added a click event .Play()

            btnDurdur.Enabled = false; // Enabled = false Uygulama açıldığında butonu tıklanmaz hale getirir.
			btnGeri.Enabled = false;   // Uygulama açıldığında butona tıklanmaz.
			btnIleri.Enabled = false;  // Uygulama açıldığında butona tıklanmaz.
			lblTime.Text = "--:--";
		}
		private void trackBarSesLvl_ValueChanged(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Audio.Volume = trackBarSesLvl.Value; //Trackbar videonun ses seviyesini ayarlar

		}
		private void dosyaEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog(); //OpenFileDialog bir dialog ekranı ile dosya seçmemize yaramaktadır
			file.Filter = "Video Dosyaları (*.mp4)|*.mp4|Tüm Dosyalar (*.*)|*.*"; //Belli uzantılara sahip dosyaları görüntülemek istersek Filter özelliğini belirtmemiz gerekecektir.
			if (file.ShowDialog()==DialogResult.OK)
			{
				vlcControl1.VlcMediaPlayer.Play(new Uri(file.FileName)); //Seçilen bir dosyayının yol bilgisi FileName özelliği ile öğrenilmektedir. 
				btnIleri.Enabled=true;      // Enabled=true Uygulama açıldığında butonu tıklanabilir hale gelir.
				btnGeri.Enabled = true;		// Uygulama açıldığında buton tıklanabilir hale gelir.
				btnDurdur.Enabled = true;	// Uygulama açıldığında buton tıklanabilir hale gelir.
				tmrVideoSure.Start();       // Uygulama açıldığında Timeri başlatır.
				vlcControl1.VlcMediaPlayer.Audio.Volume = trackBarSesLvl.Value;
			}
		}
		private void btnIleri_Click(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Time += 10000;   // Videoyu 10 saniye ileri sarar			

		}
		private void btnGeri_Click(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Time -= 10000;   //Videoyu 10 saniye geri sarar
			
		}
		private void btnDurdur_Click(object sender, EventArgs e)
		{

			if (btnDurdur.Text == "Durdur")
			{
				vlcControl1.VlcMediaPlayer.Pause();
				btnDurdur.Text = "Devam Et";
				tmrVideoSure.Stop();
			}
			else if (btnDurdur.Text == "Devam Et")
			{
				vlcControl1.VlcMediaPlayer.Play();
				btnDurdur.Text = "Durdur";
				tmrVideoSure.Start();
			}		
		}
		private void xToolStripMenuItem_Click(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Rate = 1;    //Rate özelliği Videonun hızını arttırır.
		}
		private void xToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Rate = 2;    //Videonun hızını 2x arttırır.
		}
		private void xToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			vlcControl1.VlcMediaPlayer.Rate = 3; //Videonun hızını 3x arttırır.
		}
		private void tmrVideoSure_Tick(object sender, EventArgs e)
		{
			if (vlcControl1.VlcMediaPlayer.Time > 0 && vlcControl1.VlcMediaPlayer.Time < vlcControl1.VlcMediaPlayer.Length)
			{
				// Süre hesaplama
				string sure = "";
				TimeSpan suankiSaniye = TimeSpan.FromMilliseconds(vlcControl1.VlcMediaPlayer.Time);
				int saniye = (int)suankiSaniye.TotalSeconds;
				if (saniye < 60)
				{
					sure += saniye.ToString() + "/";
				}
				else
				{
					int dakika = saniye / 60;
					int kalanSaniye = saniye % 60;
					sure += dakika + ":" + kalanSaniye + "/";
				}
				TimeSpan videoToplamSaniye = TimeSpan.FromMilliseconds(vlcControl1.VlcMediaPlayer.Length);
				int toplamSaniye = (int)videoToplamSaniye.TotalSeconds;
				if (toplamSaniye < 60)
				{
					sure += toplamSaniye.ToString();
				}
				else
				{
					int dakika = toplamSaniye / 60;
					int kalanSaniye = toplamSaniye % 60;
					sure += dakika + ":" + kalanSaniye;
				}
				lblTime.Text = sure;

				// Video oynatma trackbar konumunu ayarlama

				double ilerlemeYuzdesi = (suankiSaniye.TotalSeconds / videoToplamSaniye.TotalSeconds) * 100;
				if (ilerlemeYuzdesi >1 && ilerlemeYuzdesi <99)
				{
					trackBarVideoOynatma.Value = Convert.ToInt32(ilerlemeYuzdesi);
				}
				
				
			}
		}
		private void trackBarVideoOynatma_Scroll(object sender, EventArgs e)
		{
			int videoScrollDegeri = trackBarVideoOynatma.Value;
			double toplamVideoSure = vlcControl1.VlcMediaPlayer.Length;
			double videKonumu = (toplamVideoSure / 100) * videoScrollDegeri;
			vlcControl1.VlcMediaPlayer.Time = (long)videKonumu;




		}
	}
}
