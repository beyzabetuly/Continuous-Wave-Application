using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalgamatik
{
    public partial class Form1 : Form
    {

        List<Dalga> dalgalar = new List<Dalga>();
        int[] hizDegerleri = { 0, 100, 50, 25, 10 };
        int[] siddetDegerleri = { 150,175,200,225,255};
        int siddet = 200;
        List<DalgaKaynagi> kaynaklar = new List<DalgaKaynagi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureHavuz_MouseClick(object sender, MouseEventArgs e)
        {
            
            dalgalar.Add (new Dalga(e.Location, siddet));

        }

        private void pictureHavuz_Paint(object sender, PaintEventArgs e)
        {
            foreach (Dalga dalga in dalgalar)
            {
                Color renk = Color.FromArgb(255-dalga.siddet, 255-dalga.siddet,dalga.siddet);
                e.Graphics.DrawEllipse(new Pen(renk,4), dalga.merkez.X-dalga.cap/2, dalga.merkez.Y-dalga.cap/2, dalga.cap,dalga.cap);
            }

        }

        private void timer_Hareket_Tick(object sender, EventArgs e)
        {
            Text = "Dalgamatik" + dalgalar.Count;
            for (int i = 0; i < dalgalar.Count; i++)
            {
                Dalga dalga = dalgalar[i];
                dalga.cap += 10;
                dalga.siddet--;
                if (dalga.siddet<= 128)
                {
                    dalgalar.RemoveAt(i--);
                }
            }
            pictureHavuz.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value==0)
            {
                timer_Hareket.Stop();
            }
            else
            {
                timer_Hareket.Start();
                timer_Hareket.Interval = hizDegerleri[trackBar1.Value];
            }
        }

        private void trackBarsiddet_Scroll(object sender, EventArgs e)
        {
            siddet = siddetDegerleri[trackBarsiddet.Value];
        }

        private void pictureHavuz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                dalgalar.Add(new Dalga(e.Location, siddet));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dalgalar.Clear();
            foreach (var item in kaynaklar)
            {
                item.Stop();
            }
            kaynaklar.Clear();
        }

        private void pictureHavuz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DalgaKaynagi kaynak = new DalgaKaynagi();
            kaynak.dalga = new Dalga(e.Location, siddet);
            kaynak.Interval = 1000 / trackBarfrekans.Value;
            kaynak.Tick += Kaynak_Tick;
            kaynaklar.Add(kaynak);
            kaynak.Start();

        }

        private void Kaynak_Tick(object sender, EventArgs e)
        {
            DalgaKaynagi kaynak = (DalgaKaynagi)sender;
            dalgalar.Add(new Dalga(kaynak.dalga.merkez, kaynak.dalga.siddet));
        }
    }


    class  Dalga
    {
      public   Point merkez;
      public   int cap;
        public int siddet;


        public Dalga(Point merkez,int siddet)
        {
           this.merkez = merkez;
          this.siddet = siddet;
        }
    }
    class DalgaKaynagi : Timer
        {
        public Dalga dalga; 
    }
}

