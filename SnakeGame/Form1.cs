using MetroFramework.Forms;
using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeGame.Properties;
using System.IO;

namespace SnakeGame
{
    public partial class Form1 : MetroForm
    {      
        int satirSayisi = 25;
        int sutunSayisi = 25;
        int bogumBoyut;
        List<Point> yilan;

        int xYon = 1, yYon = 0; //default yani başlangıçtaki gidiş yönü. sağa doğru 1er adım gitsin

        bool yonDegisti = false;
        Point yem;
        Random rnd = new Random();
        bool oyunBittiMi = false;

        int puan = 0;
        bool kolayMi = false;

        string oyuncu;

        List<string> skorlar = new List<string>();

        public Form1()
        {
            Icon = Properties.Resources.snake; //oyun başladığında snake ikonu olsun diye.

            EskiSkorlariOku();
            
            InitializeComponent();
            
            Titremeyiazalt();
            bogumBoyut = saha.Height / satirSayisi; //bogum boyutum artık 20 oldu.

            YilanUret();

            YemUret();
        }

        private void EskiSkorlariOku()
        {
            try
            {
                skorlar = File.ReadAllLines("skorlar.txt").ToList();
            }
            catch (Exception)
            {
               
            }
        }

        private void Titremeyiazalt()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void YemUret()
        {
            int x, y;  //random x,y noktalarında üret.

            do
            {
                x = rnd.Next(0, sutunSayisi);
                y = rnd.Next(0, satirSayisi);
                //yem ve yılan noktalarında çakışma olmadığı sürece yeme gelene kadar random sabit bir yem üret.

            } while (YilaninUzerindeMi(x, y));  //oluşan yem yılanın üzerindeyse hemen tekrar üret değilse normal dewamke. 

            yem = new Point(x, y);
        }

        private void YilanUret()   //yılanın boğumlarının satır ve sütun değerleri hesaplanıyor.
        {
            Point orta = new Point(sutunSayisi / 2, satirSayisi / 2);

            yilan = new List<Point>
            {
                orta, //yılanın başı
                new Point(orta.X - 1, orta.Y), //yılanın gövdesi
                new Point(orta.X - 2, orta.Y)   //yılanın kuyruğu, 3 elemanlı bit yılanımız var en başta.
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //form üzerinde bir tuşa basıldığında önce bu metota girer. form1den miras olarak gelir.
        {
            if (keyData == Keys.F2)
            {
                if (oyunBittiMi)
                {
                    OyunuYenidenBaslat();
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                if (timer1.Enabled)
                {
                    timer1.Stop();
                    lblDurdu.Show();
                }
                else
                {
                    timer1.Start();
                    lblDurdu.Hide();
                    lblAcıklama.Hide();
                }
            }
            if (yonDegisti || !timer1.Enabled) //1tick süresi içinde zaten bir kere yön değişti. yön değiştiyse burdan çıkıyor. ya da timer1 enabled ise.
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            int xYeniYon;
            int yYeniYon;

            switch (keyData)
            {
                case Keys.Up:
                    xYeniYon = 0;
                    yYeniYon = -1;
                    break;
                case Keys.Down:
                    xYeniYon = 0; yYeniYon = +1;
                    break;
                case Keys.Left:
                    xYeniYon = -1; yYeniYon = 0;
                    break;
                case Keys.Right:
                    xYeniYon = +1; yYeniYon = 0;
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            if (xYeniYon * xYon != -1 && yYeniYon * yYon != -1) //yeni yön eski yönle zıt değilse (hatayı engellemk için)
            {
                xYon = xYeniYon;
                yYon = yYeniYon;

                yonDegisti = true;
            }

            return base.ProcessCmdKey(ref msg, keyData); //yani nasıl çalışcaksa öyle çalışsın biz araya girmeyelim reyiz.
        }

        private void OyunuYenidenBaslat()
        {
            puan = 0;
            lblPuan.Text = "000";
            
            xYon = +1;
            yYon = 0;
            oyunBittiMi = false;
            yonDegisti = false;

            lblOyunBitti.Hide();
            YilanUret();
            YemUret();
            saha.Refresh();
            timer1.Interval = 250;
            timer1.Start();
        }

        private void saha_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //her seferinde e.graphics yazmamak için g dedik
            YilanCiz(g);
            YemCiz(g);
        }

        private void YemCiz(Graphics g)
        {
            int x = yem.X * bogumBoyut;
            int y = yem.Y * bogumBoyut;

            g.FillRectangle(Brushes.Red, x, y, bogumBoyut, bogumBoyut);
            g.DrawRectangle(Pens.Black, x, yem.Y * bogumBoyut, bogumBoyut - 1, bogumBoyut - 1);
        }

        private bool YilaninUzerindeMi(int x, int y)  //yem yılanın üzerine gelmemeli, çakışma kontrolü
        {
            foreach (Point nokta in yilan)
            {
                if (nokta.X == x && nokta.Y == y)
                {
                    return true; //çakışma var demek
                }
            }
            return false; //çakışma yok demek
        }

        private void YilanCiz(Graphics g)
        {
            BogumCiz(g, yilan[0].X, yilan[0].Y, true); //yılanın başı hep istediğimiz renk olsun diye

            for (int i = 1; i < yilan.Count; i++)
            {
                BogumCiz(g, yilan[i].X, yilan[i].Y);
            }
        }

        private void BogumCiz(Graphics g, int sutunNo, int satirNo, bool basMi = false)  //1 adet kare çizimi
        {
            int x = sutunNo * bogumBoyut;  //boğum boyutu -> kare boyutu
            int y = satirNo * bogumBoyut;

            g.FillRectangle(basMi ? Brushes.Gray : Brushes.White, x, y, bogumBoyut, bogumBoyut);
            g.DrawRectangle(Pens.Black, x, y, bogumBoyut - 1, bogumBoyut - 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point bas = yilan[0];
            Point yeniBas = kolayMi
               ? new Point(((bas.X + 1 * xYon + sutunSayisi)%sutunSayisi), ((bas.Y + 1 * yYon + satirSayisi)%satirSayisi)) : new Point (bas.X + 1 * xYon, bas.Y + 1 * yYon);  //bas=yılanın başı.

            //POINT: (x,y) gibi 2 değişken oluşan noktaları rahat tutmaya yarıyor. normal dizi yada list yapsak iş uzar ve zorlaşır. onun yerine (x1y1),(x2,y2)leri tek nokta olarak tutuyorsun. point p1 = new point (0,0) gibi.
            //console.writeline("(" + p1.x + "," + p1.Y+ ")") şeklinde de yadırırlabilir.


            //YENİ BAŞI İNSERT ETMEDEN ÖNCE KAFASINI BİR YERE VURUYOR MU DİYE KONTROL EDELİM
            if (YilaninUzerindeMi(yeniBas.X, yeniBas.Y) || yeniBas.X < 0 || yeniBas.X >= sutunSayisi || yeniBas.Y < 0 || yeniBas.Y >= satirSayisi)
            {
                SkorKaydet();
                
                timer1.Stop();
                lblOyunBitti.Text = string.Format("OYUN BİTTİ!\r\nSKORUNUZ: {0}\r\nTEKRAR OYNA (F2)", puan);
                lblOyunBitti.Show();
                oyunBittiMi = true;
                return;
            }
            yilan.Insert(0, yeniBas);

            //YEMİ YUTTU MU?
            if (yeniBas == yem) //Yemi yuttu
            {
                puan+= kolayMi? 5 : 10; //kolay seviyede 5, zor seviyede 10 arttır.
                YemUret();  //yeni yem üretti.
                timer1.Interval = (int)(timer1.Interval * 0.95); //her yuttuğunda timer interval'ını azalt, dolayısıyla yılanı biraz hızlandır.
            }
            else
            {
                //yutmadıysa kuyruğunu sil.
                yilan.RemoveAt(yilan.Count - 1);
            }

            lblPuan.Text = puan.ToString("000"); //puanı arttırdıktan sonra puan textini güncelle
            saha.Refresh();
            //yani başa ekle kuyruktan sil... ile sürekli hareket ettirmiş oluyoruz.
            //bunu çok hızlı yaptırdığı için biz görmüyoruz ve ilerlemiş gibi görüyoruz.

            yonDegisti = false; //yılan hareket etti, tekrar yön değştirebilir.
        }

        private void SkorKaydet()
        {
            string skorMetin = string.Format("{0:00000}; {1}; {2}", puan, DateTime.Now.ToString("s"), oyuncu);
            skorlar.Add(skorMetin);
            skorlar.Sort();
            skorlar.Reverse();
            File.WriteAllLines("skorlar.txt", skorlar);
        }

        private void tsmiKolay_Click(object sender, EventArgs e)
        {
            kolayMi = true;
            tsmiKolay.Checked = true;
            tsmiZor.Checked = false;
        }

        private void tsmiZor_Click(object sender, EventArgs e)
        {
            kolayMi = false;
            tsmiKolay.Checked = false;
            tsmiZor.Checked = true;
        }

        private void tsmiSkorlar_Click(object sender, EventArgs e)
        {
            SkorlarFormcs frmSkorlar = new SkorlarFormcs();
            frmSkorlar.ShowDialog(); //sadece show deseydik 231564 tane açabilirdik ama showdialog deyince 1 kez açıyor ve kapatla çıkıyor.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void txtOyuncu_Click(object sender, EventArgs e)
        {

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            string ad = txtOyuncu.Text.Trim();

            if (ad== "")
            {
                MessageBox.Show("Lütfen adınızı giriniz");
                return;
            }
            oyuncu = ad;
            Text = "Yılan Oyunu - " + ad;
            Refresh();
            pnlGiris.Hide();
        }

        private void lblDurdu_Click(object sender, EventArgs e)
        {

        }
    }
}
