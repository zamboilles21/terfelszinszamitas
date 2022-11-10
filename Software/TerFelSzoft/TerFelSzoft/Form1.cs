using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerFelSzoft
{
    public partial class Form1 : Form
    {
        static List<Label> labelek = new List<Label>();
        static List<TextBox> textboxok = new List<TextBox>();
        static string alakzat = "";
        public Form1()
        {
            InitializeComponent();
            
            pctbx_alakzat.Image = Properties.Resources.modern_art;
            rchtxtbx_egyenlet.SelectAll();
            rchtxtbx_egyenlet.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_alakzatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                pctbx_alakzat.SendToBack();
            }
            
            lbl_input_value_1.Visible = false;
            lbl_input_value_2.Visible = false;
            lbl_input_value_3.Visible = false;
            lbl_input_value_4.Visible = false;
            lbl_input_value_5.Visible = false;
            txtbx_input_value_1.Visible = false;
            txtbx_input_value_2.Visible = false;
            txtbx_input_value_3.Visible = false;
            txtbx_input_value_4.Visible = false;
            txtbx_input_value_5.Visible = false;
            lbl_mertekegyseg_1.Visible = false;
            lbl_mertekegyseg_2.Visible = false;
            lbl_mertekegyseg_3.Visible = false;
            lbl_mertekegyseg_4.Visible = false;
            lbl_mertekegyseg_5.Visible = false;
            lbl_result_1.Visible = false;
            lbl_result_2.Visible = false;
            txtbx_result_1.Visible = false;
            txtbx_result_2.Visible = false;

            alakzat = combo_alakzatok.SelectedItem.ToString();
            for (int i = 0; i < labelek.Count; i++)
            {
                this.Controls.Remove(labelek[i]);
                labelek.RemoveAt(i);
            }
            for (int i = 0; i < textboxok.Count; i++)
            {
                this.Controls.Remove(textboxok[i]);
                textboxok.RemoveAt(i);
            }
            makeinputfields();
        }

        private void makeinputfields()
        {
            switch (alakzat)
            {
                case "Háromszög":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_mertekegyseg_4.Text = "Cm";

                        lbl_input_value_1.Text = "a oldal";
                        lbl_input_value_2.Text = "b oldal";
                        lbl_input_value_3.Text = "c oldal";
                        lbl_input_value_4.Text = "Magasság";

                        lbl_input_value_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        lbl_input_value_4.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        txtbx_input_value_4.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        lbl_mertekegyseg_4.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;

                        pctbx_alakzat.Image = Properties.Resources.triangle;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 200;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y+20);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Háromszög területe: am/2 \n -Háromszög kerülete: a2+b2=c2";



                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    
                    break;
                case "Négyzet":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;



                        pctbx_alakzat.Image = Properties.Resources.negyzet;
                        pctbx_alakzat.Width = 320;
                        pctbx_alakzat.Height = 320;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 470, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Négyzet kerülete: K = 4a \n -Négyzet területe: T = a2 = d2/2";
                        rchtxtbx_egyenlet.Visible = true;

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }

                    break;
                case "Trapéz":
                    if (true)
                    {
                        lbl_input_value_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        lbl_input_value_4.Visible = true;
                        lbl_input_value_5.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        txtbx_input_value_4.Visible = true;
                        txtbx_input_value_5.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        lbl_mertekegyseg_4.Visible = true;
                        lbl_mertekegyseg_5.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_mertekegyseg_4.Text = "Cm";
                        lbl_mertekegyseg_5.Text = "Cm";

                        lbl_input_value_1.Text = "a oldal";
                        lbl_input_value_2.Text = "b oldal";
                        lbl_input_value_3.Text = "c oldal";
                        lbl_input_value_4.Text = "d oldal";
                        lbl_input_value_5.Text = "Magasság";

                        pctbx_alakzat.Image = Properties.Resources.trap;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 200;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y+20);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Trapéz kerülete: K=a+b+c+d \n -Trapéz területe: T=(a+c)/2*m";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    
                    break;
                case "Téglalap":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.tegla_water;
                        pctbx_alakzat.Width = 300;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 450, combo_alakzatok.Location.Y-10);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Téglalap kerülete: 2a+2b \n -Téglalap területe: a*b";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Paralelogramma":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "Magasság";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.paralel;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y-10);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Paralelogramma kerülete: 2 (a+b) \n -Paralelogramma területe: T= am = ab sin α";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Rombusz":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "e átló";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "f átló";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.rombusz;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y-10);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Rombusz területe: K = 4a \n -Rombusz kerülete: T = ef/2 = a2 sin α";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Deltoid":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "e átló";
                        lbl_mertekegyseg_4.Text = "Cm";
                        lbl_input_value_4.Text = "f átló";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        lbl_input_value_4.Visible = true;
                        txtbx_input_value_4.Visible = true;
                        lbl_mertekegyseg_4.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.deltoid;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Deltoid területe: T=e*f/2 \n -Deltoid kerülete:K=1(a+b)";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Kör":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "sugár";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "átló";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.kor;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 350;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 420, combo_alakzatok.Location.Y+20);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Kör területe: T = √((s−a)(s−b)(s−c)(s−d)) \n -Kör kerülete: K = 2πr = πd";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Terület:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Kerület:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Henger":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "sugár";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "testmagasság";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.henger;
                        pctbx_alakzat.Width = 200;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 510, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Henger felszíne: A = 2πr (r + m) \n -Henger térfogata: V = πr2 m";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;



                    }
                    break;
                case "Gúla":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "Testmagasság";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "Oldalmagasság";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        lbl_input_value_3.Visible = true;
                        txtbx_input_value_3.Visible = true;
                        lbl_mertekegyseg_3.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.gula;
                        pctbx_alakzat.Width = 300;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 470, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Gúla felszíne: A = T + P \n -Gúla térfogata: V = (T m) /3";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Gömb":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "Sugár";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "Átfogó";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.gomb;
                        pctbx_alakzat.Width = 280;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 450, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Gömb felszíne: A = 4πR2 = πd2 \n -Gömb térfogata: V = (4π /3) R3 = (π /6) d3";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                
            }
        }
    }
}
