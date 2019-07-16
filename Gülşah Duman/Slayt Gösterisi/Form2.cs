using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slayt_Gösterisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           Close();
        }
        int CagirilacakResim = 0;
        Form1 form = new Form1();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CagirilacakResim += 1;
            if (CagirilacakResim > 10)
            {
                CagirilacakResim = 1;
            }
            pictureBox1.Image = form.ResimCagir(CagirilacakResim);
        }
  
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
