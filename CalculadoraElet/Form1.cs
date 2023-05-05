using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraElet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal perim_q1, perim_q2, perim_ban, perim_areas, perim_coz, perim_sala, perim_hall, perim_var;

            /* qt_1 = decimal.Parse(area_q1.Text);
             qt_2 = decimal.Parse(area_q1.Text);
             ban = decimal.Parse(area_q1.Text);
             area_s = decimal.Parse(area_q1.Text);
             cozinha = decimal.Parse(area_q1.Text);
             sala = decimal.Parse(area_q1.Text);
             hall = decimal.Parse(area_q1.Text);
             varanda = decimal.Parse(area_q1.Text);*/

            perim_q1 = decimal.Parse(per_q1.Text);
            perim_q2 = decimal.Parse(per_q2.Text);
            perim_ban = decimal.Parse(per_ban.Text);
            perim_areas = decimal.Parse(per_serv.Text);
            perim_coz = decimal.Parse(per_coz.Text);
            perim_sala = decimal.Parse(per_sala.Text);
            perim_hall = decimal.Parse(per_hall.Text);
            perim_var = decimal.Parse(per_varanda.Text);

            if (perim_q1 <= 6) // tomadas quarto 1
            {
                int tug_q1 = 1;
                label13.Text = tug_q1.ToString();
                int pot_q1 = tug_q1 * 100;
                label14.Text = pot_q1.ToString();

            }
            else
            {
                var tug_q1 = Math.Ceiling(perim_q1 / 5);
                label13.Text = tug_q1.ToString();
                var pot_q1 = tug_q1 * 100;
                label14.Text = pot_q1.ToString();
            }

            if (perim_q2 <= 6) // tomadas quarto 2
            {
                int tug_q2 = 1;
                label16.Text = tug_q2.ToString();
                int pot_q2 = tug_q2 * 100;
                label15.Text = pot_q2.ToString();

            }
            else
            {
                var tug_q2 = Math.Ceiling(perim_q2 / 5);
                label16.Text = tug_q2.ToString();
                var pot_q2 = tug_q2 * 100;
                label15.Text = pot_q2.ToString();
            }

            if (perim_ban <= 6) // tomadas banheiro
            {
                int tug_ban = 2;
                label18.Text = tug_ban.ToString();
                int pot_ban = tug_ban * 100;
                label17.Text = pot_ban.ToString();

            }
            else
            {
                var tug_ban = Math.Ceiling(perim_ban / 5);
                label18.Text = tug_ban.ToString();
                var pot_ban = tug_ban * 600;
                label17.Text = pot_ban.ToString();
            }

            if (perim_areas <= 6) // tomadas área serviço
            {
                int tug_areas = 1;
                label20.Text = tug_areas.ToString();
                int pot_areas = tug_areas * 100;
                label19.Text = pot_areas.ToString();

            }
            else
            {
                double a = 3.5;
                var b = Convert.ToDouble(perim_areas);
                
                var tug_ban = Math.Ceiling(a/b);
                label20.Text = tug_ban.ToString();
                var pot_ban = tug_ban * 600;
                label19.Text = pot_ban.ToString();
            }

            if (perim_coz <= 6) // tomadas cozinha
            {
                int tug_coz = 1;
                label28.Text = tug_coz.ToString();
                int pot_coz = tug_coz * 100;
                label27.Text = pot_coz.ToString();

            }
            else
            {
                double a = 3.5;
                var bb = Convert.ToDouble(perim_coz);

                var tug_coz = Math.Ceiling(a / bb);
                label28.Text = tug_coz.ToString();
                var pot_coz = tug_coz * 600;
                label27.Text = pot_coz.ToString();
            }

            if (perim_sala <= 6) // tomadas sala
            {
                int tug_sala = 1;
                label26.Text = tug_sala.ToString();
                int pot_sala = tug_sala * 100;
                label25.Text = pot_sala.ToString();

            }
            else
            {
                var tug_sala = Math.Ceiling(perim_sala / 5);
                label26.Text = tug_sala.ToString();
                var pot_sala = tug_sala * 100;
                label25.Text = pot_sala.ToString();
            }

            if (perim_hall <= 6) // tomadas hall
            {
                int tug_hall = 1;
                label24.Text = tug_hall.ToString();
                int pot_hall = tug_hall * 100;
                label23.Text = pot_hall.ToString();

            }
            else
            {
                var tug_hall = Math.Ceiling(perim_hall / 5);
                label24.Text = tug_hall.ToString();
                var pot_hall = tug_hall * 100;
                label23.Text = pot_hall.ToString();
            }

            if (perim_var <= 6) // tomadas sala
            {
                int tug_var = 1;
                label22.Text = tug_var.ToString();
                int pot_var = tug_var * 100;
                label21.Text = pot_var.ToString();

            }
            else
            {
                var tug_var = Math.Ceiling(perim_var / 5);
                label22.Text = tug_var.ToString();
                var pot_var = tug_var * 100;
                label21.Text = pot_var.ToString();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void per_q1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
