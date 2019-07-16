using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slayt_Gösterisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private int suankiResim;
        private void Form1_Load(object sender, EventArgs e) //Form başladığı anda 
        {
            suankiResim = 1;
            pictureBox1.Image = ResimCagir(1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(1);
            suankiResim = 1;
        }
        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height); //Döndüreceğimiz resmin boyutlarını girdik.
            Graphics g = Graphics.FromImage(result); //Yazacağımız resmin boyutlarını aldık.
            g.DrawImage(bmp, 0, 0, width, height); //Resim ayarlarını yaptık (Düzenleyeceğimiz resim - Location , Location - En - Boy)
      
            return result;//Resmi çizdikten sonra döndürdük.
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(2);
            suankiResim = 2;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(3);
            suankiResim = 3;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(4);
            suankiResim = 4;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(5);
            suankiResim = 5;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(6);
            suankiResim = 6;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(7);
            suankiResim = 7;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(8);
            suankiResim = 8;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(9);
            suankiResim = 9;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(10);
            suankiResim = 10;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1,10);
            pictureBox1.Image = ResimCagir(rastgeleSayi);
            suankiResim = rastgeleSayi;
        }
        public Bitmap ResimCagir(int deger)
        {
            if (deger == 1)
            {
                return ResizeBitmap(Properties.Resources.image1, 442, 228);
            }
            if (deger == 2)
            {
                return ResizeBitmap(Properties.Resources.image2, 442, 228);
            }
            if (deger == 3)
            {
                return ResizeBitmap(Properties.Resources.image3, 442, 228);
            }
            if (deger == 4)
            {
                return ResizeBitmap(Properties.Resources.image4, 442, 228);
            }
            if (deger == 5)
            {
                return ResizeBitmap(Properties.Resources.image5, 442, 228);
            }
            if (deger == 6)
            {
                return ResizeBitmap(Properties.Resources.image6, 442, 228);
            }
            if (deger == 7)
            {
                return ResizeBitmap(Properties.Resources.image7, 442, 228);
            }
            if (deger == 8)
            {
                return ResizeBitmap(Properties.Resources.image8, 442, 228);
            }
            if (deger == 9)
            {
                return ResizeBitmap(Properties.Resources.image9, 442, 228);
            }
            if (deger == 10)
            {
                return ResizeBitmap(Properties.Resources.image10, 442, 228);
            }
            return null; //Boş döndürüldü
        }
       

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(10);
            suankiResim = 10;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ResimCagir(1);
            suankiResim = 1;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (suankiResim == 1)
            {
                MessageBox.Show("Resim 1'deyken önceki resme gidilemez.");
                return;
            }
            int gecilecekResim = suankiResim - 1;
           pictureBox1.Image = ResimCagir(gecilecekResim);
            suankiResim = gecilecekResim;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (suankiResim == 10)
            {
                MessageBox.Show("Resim 10'dayken sonraki resme gidilemez.");
                return;
            }
            int gecilecekResim = suankiResim + 1;
            pictureBox1.Image = ResimCagir(gecilecekResim);
            suankiResim = gecilecekResim;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
