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

namespace Placar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarImg(pb_time1, lb_time1.Text);
            CarregarImg(pb_time2, lb_time2.Text);
        }

        private void CarregarImg(PictureBox pb_time, string text)
        {
            if (text.Equals("Corinthians"))
            {
                pb_time.Image = Properties.Resources.corinthians1;
            }

            else if (text.Equals("Torre"))
            {
                pb_time.Image = Properties.Resources.torre;
            }

            else if (text.Equals("Santos"))
            {
                pb_time.Image = Properties.Resources.santos;
            }

            else if (text.Equals("São Paulo"))
            {
                pb_time.Image = Properties.Resources.sp;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_maisTime1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lb_result1.Text);
            score++;
            lb_result1.Text = score.ToString();
        }

        private void bt_menosTime1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lb_result1.Text);
            if(score > 0)
            {
                score--;
                lb_result1.Text = score.ToString();
            }
            
        }

        private void bt_maisTime2_Click(object sender, EventArgs e)
        {

            int score = int.Parse(lb_result2.Text);
            score++;
            lb_result2.Text = score.ToString();

        }

        private void bt_menosTime2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lb_result2.Text);
            if (score > 0)
            {
                score--;
                lb_result2.Text = score.ToString();
            }
        }

        int min = 00, seg = 00;

        private void button1_Click(object sender, EventArgs e)
        {
            AtivarBtns();

            if(min == 90)
            {
                string resultadoFinal = lb_time1.Text + ": " +
                lb_result1.Text + " " +
                lb_time2.Text + ": " +
                lb_result2.Text + "  Tempo: " +
                min + ":" +
                seg;

                MessageBox.Show(resultadoFinal);

                min = 0;
                seg = 0;
                lb_timer.Text = "00:00";
                iniciar.Text = "Começar jogo";
                lb_result1.Text = "0";
                lb_result2.Text = "0";
                initgame.Text = "2º Tempo";
            }

            else
            {
                cronometro.Enabled = true;
                iniciar.Visible = false;
            }
           
        }

        private void AtivarBtns()
        {
            bt_maisTime1.Enabled = true;
            bt_maisTime2.Enabled = true;

            bt_menosTime1.Enabled = true;
            bt_menosTime2.Enabled = true;
        }

        private void DesativarBtns()
        {
            bt_maisTime1.Enabled = false;
            bt_maisTime2.Enabled = false;

            bt_menosTime1.Enabled = false;
            bt_menosTime2.Enabled = false;
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            string texto = "";
            if (min < 10)
            {
                texto += "0" + min;
            }

            else
            {
                texto += min;
            }

            if(seg < 10)
            {
                texto += ":0" + seg;
            }

            else
            {
                texto += ":" + seg;
            }

            lb_timer.Text = texto;

            if (min < 45) {

                initgame.Text = "1º Tempo";
            }

            else
            {
                initgame.Text = "2º Tempo";
            }


            if((min == 45 && seg == 0) || (min == 90))
            {
                cronometro.Enabled = false;
                iniciar.Visible = true;
                DesativarBtns();
            }

            if(min == 45)
            {
                iniciar.Text = "Começar segundo tempo";
            }

            else if(min == 90)
            {
                iniciar.Text = "Iniciar novo jogo";
            }

        }
    }
}
