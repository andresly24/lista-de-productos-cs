using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace vista
{
    public partial class blackjack : UserControl
    {
        ArrayList cartas = new ArrayList() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        Random random = new Random();

        int nwx = 0;
        int nwxR = 0;

        int sumaR;
        int sumaJ;

        Panel panelJ = new Panel();
        Panel panelR = new Panel();

        public blackjack()
        {
            InitializeComponent();
        }

        private void play_bj()
        {

            int rn1 = random.Next(cartas.Count);
            int rn2 = random.Next(cartas.Count);
            int jn1 = random.Next(cartas.Count);
            int jn2 = random.Next(cartas.Count);


            rcn1.Text = (string)cartas[rn1];
            rcn2.Text = (string)cartas[rn2];
            jcn1.Text = (string)cartas[jn1];
            jcn2.Text = (string)cartas[jn2];



            if (rn1 >= 10)
            {
                rn1 = 9;
            }
            if (rn2 >= 10)
            {
                rn2 = 9;
            }
            if (jn1 >= 10)
            {
                jn1 = 9;
            }
            if (jn2 >= 10)
            {
                jn2 = 9;
            }

            rn1 += 1;
            rn2 += 1;

            jn1 += 1;
            jn2 += 1;

            sumaR = (rn1) + (rn2);
            sumaJ = (jn1) + (jn2);

            rcount.Text = sumaR.ToString();
            jcount.Text = sumaJ.ToString();

            if (sumaR == 21 && sumaJ == 21 || ((rn1 == 10 && rn2 == 1) || (rn1 == 1 && rn2 == 10) && (jn1 == 10 && jn2 == 1) || (jn1 == 1 && jn2 == 10)))
            {
                rlabel.Text = "Empate";
                jlabel.Text = "Empate";

                seguirbtn.Enabled = false;
                pararbtn.Enabled = false;
                reiniciarbtn.Enabled = true;
            }

            if (sumaR == 21 || (rn1 == 10 && rn2 == 1) || (rn1 == 1 && rn2 == 10))
            {
                rlabel.Text = "Ganaste";
                jlabel.Text = "Perdiste";
                rcount.Text = "21";

                seguirbtn.Enabled = false;
                pararbtn.Enabled = false;
                reiniciarbtn.Enabled = true;
            }

            if (sumaJ == 21 || (jn1 == 10 && jn2 == 1) || (jn1 == 1 && jn2 == 10))
            {
                rlabel.Text = "Perdiste";
                jlabel.Text = "Ganaste";
                jcount.Text = "21";

                seguirbtn.Enabled = false;
                pararbtn.Enabled = false;
                reiniciarbtn.Enabled = true;
            }
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            play_bj();
            playbtn.Enabled = false;

            jc1.Visible = true;
            jc2.Visible = true;

            rc1.Visible = true;
            rc2.Visible = true;

            seguirbtn.Visible = true;
            pararbtn.Visible = true;

            reiniciarbtn.Enabled = true;
        }

        private void blackjack_Load(object sender, EventArgs e)
        {
            jc1.Visible = false;
            jc2.Visible = false;

            rc1.Visible = false;
            rc2.Visible = false;

            seguirbtn.Visible = false;
            pararbtn.Visible = false;

            reiniciarbtn.Enabled = false;
        }

        private void seguir()
        {
            Panel nwp = new Panel();
            Label labelS = new Label();
            Label labelN = new Label();

            int jn1 = random.Next(cartas.Count);
            labelN.Text = (string)cartas[jn1];


            labelN.Location = new Point(21, 1);
            labelN.Size = new Size(62, 65);
            labelN.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            labelN.BackColor = Color.Transparent;

            labelS.Text = "♠";
            labelS.Size = new Size(81, 86);
            labelS.Location = new Point(14, 45);
            labelS.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            labelS.BackColor = Color.Transparent;

            nwx += 60;
            nwp.Location = new Point(nwx, 0);
            nwp.Size = new Size(103, 134);
            nwp.BackColor = Color.White;


            nwp.Controls.Add(labelS);
            nwp.Controls.Add(labelN);
            panelJ.Location = new Point(332, 329);
            panelJ.Size = new Size(502, 135);
            panel3.Controls.Add(panelJ);
            panelJ.Controls.Add(nwp);

            nwp.BringToFront();
            labelN.BringToFront();
            panelJ.BringToFront();

            if (jn1 >= 10)
            {
                jn1 = 9;
            }
            jn1 += 1;
            sumaJ += jn1;

            jcount.Text = sumaJ.ToString();
        }
        private void seguirbtn_Click(object sender, EventArgs e)
        {
            seguir();

            if (sumaJ > 21)
            {
                rlabel.Text = "Ganaste";
                jlabel.Text = "Perdiste";
                seguirbtn.Enabled = false;
                pararbtn.Enabled = false;
            }
            else if (sumaJ == 21)
            {
                rlabel.Text = "Perdiste";
                jlabel.Text = "Ganaste";
                seguirbtn.Enabled = false;
                pararbtn.Enabled = false;
            }

        }

        private void parar()
        {
            Panel nwpR = new Panel();
            Label labelSR = new Label();
            Label labelNR = new Label();

            int jn1R = random.Next(cartas.Count);
            labelNR.Text = (string)cartas[jn1R];

            labelNR.Location = new Point(21, 1);
            labelNR.Size = new Size(62, 65);
            labelNR.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            labelNR.BackColor = Color.Transparent;

            labelSR.Text = "♠";
            labelSR.Size = new Size(81, 86);
            labelSR.Location = new Point(14, 45);
            labelSR.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            labelSR.BackColor = Color.Transparent;

            nwxR += 60;
            nwpR.Location = new Point(nwxR, 0);
            nwpR.Size = new Size(103, 134);
            nwpR.BackColor = Color.White;


            nwpR.Controls.Add(labelSR);
            nwpR.Controls.Add(labelNR);
            panelR.Location = new Point(332, 82);
            panelR.Size = new Size(502, 135);
            panel3.Controls.Add(panelR);
            panelR.Controls.Add(nwpR);

            nwpR.BringToFront();
            labelNR.BringToFront();
            panelR.BringToFront();

            jn1R += 1;
            sumaR += jn1R;

            rcount.Text = sumaR.ToString();
        }

        private void reiniciarbtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Remove(panelJ);
            panelJ.Controls.Clear();

            panel3.Controls.Remove(panelR);
            panelR.Controls.Clear();

            nwx = 0;
            nwxR = 0;
            sumaR = 0;
            sumaJ = 0;
            rcount.Text = "";
            jcount.Text = "";
            rlabel.Text = "";
            jlabel.Text = "";
            seguirbtn.Enabled = true;
            pararbtn.Enabled = true;
            play_bj();
            

        }
        private void pararbtn_Click(object sender, EventArgs e)
        {
            while (true)
            {
                parar();

                if (sumaR > 21)
                {
                    rlabel.Text = "Perdiste";
                    jlabel.Text = "Ganaste";
                    seguirbtn.Enabled =false;
                    pararbtn.Enabled=false;
                    break;
                }
                else if (sumaR > sumaJ && sumaR > 21)
                {
                    rlabel.Text = "Ganaste";
                    jlabel.Text = "Perdiste";
                    seguirbtn.Enabled = false;
                    pararbtn.Enabled = false;
                    break;
                }
            }
            
        }
    }
}
