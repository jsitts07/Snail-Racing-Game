using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace Snails
{
    public partial class Form1 : Form
    {
        const int StartX = 50;
        const int FinishX = 750;
        List<Snails> snailss = new List<Snails>();
        SoundPlayer vroom = new SoundPlayer(Properties.Resources.vroom);

        public Form1()
        {
            InitializeComponent();


            //Snails s = new Snails(StartX, 50, Properties.Resources.snail1);
            //snailss.Add(s);
            //s = new Snails(StartX, 150, Properties.Resources.snail2);
            //snailss.Add(s);
            //s = new Snails(StartX, 250, Properties.Resources.snail3);
            //snailss.Add(s);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Snails s in snailss)
            {
                s.Draw(e.Graphics); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Snails s in snailss)
            {
                s.Move(); 

                if(s.X > FinishX)
                {
                    timer1.Stop();
                }
            }

            pictureBox1.Invalidate(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSnails(); 
            vroom.Play();
            timer1.Start(); 
        }

        void CreateSnails()
        {
            snailss.Clear(); 

            Snails s = new Snails(StartX, 50, Properties.Resources.snail1);
            snailss.Add(s);
            s = new Snails(StartX, 150, Properties.Resources.snail2);
            snailss.Add(s);
            s = new Snails(StartX, 250, Properties.Resources.snail3);
            snailss.Add(s);
        }
    }
}
