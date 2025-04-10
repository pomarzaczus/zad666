using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 formularz;
        int czas1;
        public Form3(Form1 test)
        {
            formularz = test;
            czas.Text = czas1.ToString();

            InitializeComponent();
        }
        int polozenieX;
        int polozenieY;

        class leButton:Button
        {
            public bool dydalf;
            public bool krox;
            public bool szop;
        }
        List<leButton> butons = [];
        private void create_plansza()
        {
            
            
            float someDouble = this.Size.Width;
            polozenieX = (int)(0.1 * someDouble);
            someDouble = this.Size.Height;
            polozenieY = (int)(0.1 * someDouble);
            int width =400;
            int height = 400;
            int licznik = 0;
            for (int i = 0; i < formularz.x; i++) {
                for (int j = 0; j < formularz.y; j++)
                {
                    butons[licznik] = new leButton();
                    butons[licznik].Height = width / formularz.y;
                    butons[licznik].Width = height / formularz.x;
                    butons[licznik].ForeColor = Color.Blue;
                    butons[licznik].Location = new Point(polozenieY +j* butons[licznik].Height, polozenieX + j * butons[licznik].Height);
                    butons[licznik].Click += new EventHandler(klik);
                    butons[licznik].Name = i.ToString()+"_"+j.ToString();
                    //losowanie kroxuw , szopy dydunie
                    licznik++;
                }
                

            }
            //this.Size.Width;
        }
        private void klik(object sender, EventArgs e)
        {
            leButton temp = (leButton)sender; //sender as leButton;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas1 -= 1;
            czas.Text = czas1.ToString();
            if (czas1 == 0)
            {
                czas.Text = " koniec ";
            }
        }
    }
}
