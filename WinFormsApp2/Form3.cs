using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.Web;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 formularz;
        int czas1 = 0;

        int kroxy;
        int dydalf;
        int szop;
        public Form3(Form1 test)
        {
            formularz = test;
            czas1 = 0;
            kroxy = formularz.kroxy;
            dydalf = formularz.dyd;
            szop = formularz.szopy;
            InitializeComponent();
            create_plansza();


        }
        int polozenieX;
        int polozenieY;

        public class leButton : Button
        {
            public bool dydalf = false;
            public bool krox = false;
            public bool szop = false;
            public int i;
            public int j;
        }
        List<leButton> butons = [];
        private void create_plansza()
        {
            var rand = new Random();

            float someDouble = this.Size.Width;
            polozenieX = (int)(0.01 * someDouble);
            someDouble = this.Size.Height;
            polozenieY = (int)(0.01 * someDouble);
            int width = 400;
            int height = 400;
            int licznik = 0;
            int[] tab = new int[formularz.x * formularz.y]; //losowanie wartosci
            int ileadds = kroxy + dydalf + szop;
            for (int i = 0; i < tab.Length; i++)
            {
                if (kroxy > 0)
                {
                    tab[i] = 1;
                    kroxy--;
                }
                else
                if (dydalf > 0)
                {
                    tab[i] = 2;
                    dydalf--;
                }
                else
                if (szop > 0)
                {
                    tab[i] = 3;
                    szop--;
                }
                else
                {
                    tab[i] = 0;
                }


            }
            Random rnd = new Random();
            List<int> tab_szuhffle = [];
            foreach (var item in tab)
            {
                int position = rnd.Next(tab_szuhffle.Count);
                tab_szuhffle.Add((position == tab_szuhffle.Count) ? item : tab_szuhffle[position]);
                tab_szuhffle[position] = item;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                debug.Text += " " + tab_szuhffle[i];
            }


            for (int i = 0; i < formularz.x; i++)
            {
                for (int j = 0; j < formularz.y; j++)
                {
                    butons.Add(new leButton());
                    //butons[licznik].Height = width / formularz.y;
                    //butons[licznik].Width = height / formularz.x;
                    butons[licznik].Height = width / formularz.x;
                    butons[licznik].Width = height / formularz.y;
                    butons[licznik].ForeColor = Color.Blue;
                    butons[licznik].Location = new Point(polozenieY + j * butons[licznik].Width, polozenieX + i * butons[licznik].Height);
                    butons[licznik].Click += new EventHandler(klik);
                    butons[licznik].Name = i.ToString() + "_" + j.ToString();
                    butons[licznik].i = i;
                    butons[licznik].j = j;
                    this.Controls.Add(butons[licznik]);
                    butons[licznik].Visible = true;
                    butons[licznik].Show();
                    switch (tab_szuhffle[licznik])
                    {
                        case 1:

                            butons[licznik].krox = true;
                            //   butons[licznik].Text = "D";
                            break;
                        case 2:
                            butons[licznik].dydalf = true;
                            //  butons[licznik].Text = "K";
                            break;
                        case 3:
                            butons[licznik].szop = true;
                            //   butons[licznik].Text = "S";
                            break;
                        default:
                            // butons[licznik].Text = "O";
                            break;
                    }
                    //losowanie kroxuw , szopy dydunie
                    licznik++;
                }


            }


            //this.Size.Width;
        }
        int kroxy_licznik = 0;
        int dydalf_licznik = 0;
        int szop_licznik = 0;
        private static System.Timers.Timer aTimer;
        private static szopTimet aTimerSZOP;
        class szopTimet : System.Timers.Timer
        {
            public Form3 fomular;
            public leButton buton;
        }
        bool timerKROXActive = false;
        private void klik(object sender, EventArgs e)
        {
            leButton temp = (leButton)sender; //sender as leButton;
            label3.Text = "i = " + temp.i.ToString() + "  j = " + temp.j.ToString();
            if (czas.Text != "koniec" || czas.Text != "win")
            {
                if (timer1.Enabled == false) czas.Text = "koniec";
                if (temp.dydalf)
                {
                    dydalf_licznik++;
                    if (dydalf_licznik > formularz.dyd - 1)
                    {
                        timer1.Stop();
                        czas.Text = "win";
                        return;
                    }
                    debug.Text = "D";
                    temp.Text = "D";
                    return;
                }
                else
                if (temp.krox)
                {
                    if (timerKROXActive)
                    {
                        duration = 0;
                        timerKROXActive = false;
                        aTimer.Stop();
                        return;
                    }
                    temp.Text = "K";

                    aTimer = new System.Timers.Timer();
                    aTimer.Interval = 100;
                    aTimer.Elapsed += OnTimedEvent;
                    timerKROXActive = true;
                    aTimer.Start();
                    return;
                }
                else
                if (temp.szop)
                {
                    temp.Text = "S";
                    aTimerSZOP = new szopTimet();
                    aTimerSZOP.Interval = 2000;
                    aTimerSZOP.buton = temp;
                    aTimerSZOP.Elapsed += OnTimedEvent2;
                    aTimerSZOP.fomular = this;
                    aTimerSZOP.Start();

                    return;
                }
                else
                {
                    temp.Text = "O";
                }

            }
            
        }
        int duration = 0;

        private void popUp()
        {
            timer1.Stop();
            timer1.Enabled = false;
            //czas.Text = "koniec";
            System.Windows.Forms.MessageBox.Show("BUllShit");
            // this.Close();
        }
        int currentX;
        int currentY;
        string nameofcurrent;
        bool szopelapesd = false;
        private void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
        {

            szopTimet temp = (szopTimet)source;
            //temp.fomular.debug.Text = "XXXXX";
            int tempX = 0;
            int tempY = 0;
            string jezyutempowbrakuje = "";
            bool czyY = false;
            for (int i = 0; i < temp.buton.Name.Length; i++)
            {
                if (temp.buton.Name[i] == '_')
                {
                    tempX = Int32.Parse(jezyutempowbrakuje);
                    jezyutempowbrakuje = "";
                    czyY = true;
                    continue;
                }
                if (czyY)
                {
                    jezyutempowbrakuje += temp.buton.Name[i];

                }
                else
                {
                    jezyutempowbrakuje += temp.buton.Name[i];
                }

            }
            tempY = Int32.Parse(jezyutempowbrakuje);
            currentX = tempX;
            currentY = tempY;
            szopelapesd = true;
            nameofcurrent = temp.buton.Name;
            temp.Stop();
        }



        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            duration++;
            if (duration > 10)
            {
                aTimer.Stop();
                timer1.Stop();
                popUp();



            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas1++;
            timer1.ToString();
            czas.Text = czas1.ToString();
            // czas.Text = timer1.ToString();
            if (czas1 > formularz.czas)
            {
                czas.Text = "koniec";
                timer1.Stop();
                popUp();

                return;
            }
            if (timer1.Enabled == false)
            {
                czas.Text = "koniec";
            }
        }

        private void czas_Click(object sender, EventArgs e)
        {

        }
        public void xdddddddddddddddddddddd(int tempX, int tempY)
        {
            int licznik = 0;
            debug.Text = nameofcurrent + " ";
            foreach (leButton item in butons)
            {
                if (item.Name == nameofcurrent)
                {
                    item.Text = "";
                    if (item.i + 1 < formularz.x) { butons[licznik + 1].Text = ""; debug.Text += (licznik + formularz.x).ToString() + " "; } // i 3 licz 15            

                    if (item.i - 1 >= 0) { butons[licznik - 1].Text = ""; debug.Text += (licznik - formularz.x).ToString() + " "; }// i 1 licz 5
                    if (item.j + 1 < formularz.y && licznik + formularz.x < butons.Count) { butons[licznik + formularz.x].Text = ""; debug.Text += (licznik + 1).ToString() + " "; } // j 1 licz 11
                    if (item.j - 1 >= 0 && licznik - formularz.x >= 0){ butons[licznik - formularz.x].Text = ""; debug.Text += (licznik - 1).ToString() + " "; } //j -1 licz null
                    break; 
                }
                licznik++;
            }

            
            
            /* if (tempX + tempY * tempX + 1 < butons.Count) { butons[tempX + tempY * tempX + 1].Text = ""; }
             if (tempX + tempY * tempX - 1 >= 0) { butons[tempX + tempY * tempX - 1].Text = ""; }
             if (tempX + tempY * tempX - tempY >= 0) { butons[tempX + tempY * tempX - tempY].Text = ""; }
             if (tempX + tempY * tempX + tempY < butons.Count) { butons[tempX + tempY * tempX + tempY].Text = ""; }*/
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = szopelapesd.ToString();
            if (szopelapesd)
            {
                xdddddddddddddddddddddd(currentX, currentY);
                szopelapesd = false;
            }

            if (czas.Text == "koniec")
            {
                for (int i = 0; i < butons.Count; i++)
                {
                    butons[i].Enabled = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
