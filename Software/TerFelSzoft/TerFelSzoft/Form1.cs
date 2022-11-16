﻿using System;
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
            bool notint_input_1 = txtbx_input_value_1.Text.All(Char.IsDigit);
            bool notint_input_2 = txtbx_input_value_2.Text.All(Char.IsDigit);
            bool notint_input_3 = txtbx_input_value_3.Text.All(Char.IsDigit);
            bool notint_input_4 = txtbx_input_value_4.Text.All(Char.IsDigit);
            bool notint_input_5 = txtbx_input_value_5.Text.All(Char.IsDigit);

            if (!notint_input_1||!notint_input_2||!notint_input_3||!notint_input_4||!notint_input_5)
            {
                MessageBox.Show("Nem számot adott meg!");
            }
            else
            {
                int input_value_1 = 0;
                int input_value_2 = 0;
                int input_value_3 = 0;
                int input_value_4 = 0;
                int input_value_5 = 0;


                if (txtbx_input_value_1.Text != "")
                {
                    input_value_1 = Convert.ToInt32(txtbx_input_value_1.Text);
                }
                if (txtbx_input_value_2.Text != "")
                {
                    input_value_2 = Convert.ToInt32(txtbx_input_value_2.Text);
                }
                if (txtbx_input_value_3.Text != "")
                {
                    input_value_3 = Convert.ToInt32(txtbx_input_value_3.Text);
                }
                if (txtbx_input_value_4.Text != "")
                {
                    input_value_4 = Convert.ToInt32(txtbx_input_value_4.Text);
                }
                if (txtbx_input_value_5.Text != "")
                {
                    input_value_5 = Convert.ToInt32(txtbx_input_value_5.Text);
                }




                switch (alakzat)
                {
                    case "Háromszög":

                        int aoldal_tri = input_value_1;
                        int boldal_tri = input_value_2;
                        int coldal_tri = input_value_3;
                        int magassag_tri = input_value_4;
                        txtbx_result_1.Text = ((aoldal_tri * magassag_tri) / 2).ToString();
                        txtbx_result_2.Text = (aoldal_tri + boldal_tri + coldal_tri).ToString();

                        break;
                    case "Négyzet":
                        int aoldal_square = input_value_1;
                        txtbx_result_2.Text = (4 * aoldal_square).ToString();
                        txtbx_result_1.Text = (aoldal_square * aoldal_square).ToString();


                        break;
                    case "Téglalap":
                        int aoldal_brick = input_value_1;
                        int boldal_brick = input_value_2;

                        txtbx_result_2.Text = ((2 * aoldal_brick) + (2 * boldal_brick)).ToString();
                        txtbx_result_1.Text = (aoldal_brick * boldal_brick).ToString();

                        break;
                    case "Kör":
                        int kor_sugar = input_value_1;

                        txtbx_result_2.Text = (2 * Math.PI * kor_sugar).ToString();
                        txtbx_result_1.Text = ((kor_sugar * kor_sugar) * Math.PI).ToString();


                        break;
                    case "Rombusz":
                        int aoldal_rom = input_value_1;
                        int eatlo_rom = input_value_2;
                        int fatlo_rom = input_value_3;

                        txtbx_result_2.Text = (4 * aoldal_rom).ToString();
                        txtbx_result_1.Text = ((eatlo_rom * fatlo_rom) / 2).ToString();
                        break;
                    case "Deltoid":
                        int aoldal_del = input_value_1;
                        int boldal_del = input_value_2;
                        int eatlo_del = input_value_3;
                        int fatlo_del = input_value_4;

                        txtbx_result_2.Text = ((aoldal_del + boldal_del) * 2).ToString();
                        txtbx_result_1.Text = ((eatlo_del * fatlo_del) / 2).ToString();


                        break;
                    case "Paralelogramma":
                        int aoldal_par = input_value_1;
                        int boldal_par = input_value_2;
                        int magassag_par = input_value_3;

                        txtbx_result_2.Text = ((aoldal_par + boldal_par) * 2).ToString();
                        txtbx_result_1.Text = (aoldal_par * magassag_par).ToString();


                        break;
                    case "Trapéz":
                        int aoldal_trap = input_value_1;
                        int boldal_trap = input_value_2;
                        int coldal_trap = input_value_3;
                        int doldal_trap = input_value_4;
                        int magassag_trap = input_value_5;

                        txtbx_result_2.Text = (aoldal_trap + boldal_trap + coldal_trap + doldal_trap).ToString();
                        txtbx_result_1.Text = ((aoldal_trap + coldal_trap) / 2 * magassag_trap).ToString();

                        break;
                    case "Gúla":
                        int gula_aoldal = input_value_1;
                        int gula_testmagassag = input_value_2;
                        int gula_oldalmagassag = input_value_3;

                        txtbx_result_2.Text = ((gula_testmagassag * Math.Pow(gula_aoldal, 2)) / 3).ToString();
                        txtbx_result_1.Text = (Math.Pow(gula_aoldal, 2) + ((gula_aoldal * gula_oldalmagassag) / 2)).ToString();

                        break;
                    case "Gömb":
                        int gomb_sugar = input_value_1;


                        txtbx_result_2.Text =                                                                             (1, 25 * (Math.PI * Math.Pow(gomb_sugar, 3))).ToString();//(Math.PI * (Math.Pow(gomb_sugar * 2, 2))).ToString();
                        txtbx_result_1.Text =                                                                            (4 * Math.PI * Math.Pow(gomb_sugar, 2)).ToString();//((Math.PI / 6) * Math.Pow(gomb_sugar, 3)).ToString();

                        break;
                    case "Henger":
                        int henger_sugar = input_value_1;
                        int henger_magassag = input_value_2;

                        txtbx_result_2.Text = (((Math.PI * (henger_sugar * henger_sugar))) * henger_magassag).ToString();
                        txtbx_result_1.Text = (((Math.PI * 2) * henger_sugar) * (henger_sugar + henger_magassag)).ToString();
                        break;
                }
            }


            
            
        }

        private void combo_alakzatok_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            for (int i = 0; i < 10; i++)
            {
                pctbx_alakzat.SendToBack();
            }
            txtbx_input_value_1.Text = "";
            txtbx_input_value_2.Text = "";
            txtbx_input_value_3.Text = "";
            txtbx_input_value_4.Text = "";
            txtbx_input_value_5.Text = "";

            txtbx_result_1.Text = "";
            txtbx_result_2.Text = "";


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
            lbl_output_measure_1.Visible = false;
            lbl_output_measure_2.Visible = false;

            alakzat = combo_alakzatok.SelectedItem.ToString();
            
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
                        

                        lbl_input_value_1.Text = "a oldal:";
                        lbl_input_value_2.Text = "b oldal:";
                        lbl_input_value_3.Text = "c oldal:";
                        lbl_input_value_4.Text = "Magasság:";

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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;

                        pctbx_alakzat.Image = Properties.Resources.triangle;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 200;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y+20);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Háromszög területe: am/2 \n -Háromszög kerülete: a+b+c";



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
                        lbl_input_value_1.Text = "a oldal:";
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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;
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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_mertekegyseg_4.Text = "Cm";
                        lbl_mertekegyseg_5.Text = "Cm";

                        lbl_input_value_1.Text = "a oldal:";
                        lbl_input_value_2.Text = "b oldal:";
                        lbl_input_value_3.Text = "c oldal:";
                        lbl_input_value_4.Text = "d oldal:";
                        lbl_input_value_5.Text = "Magasság:";

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
                        lbl_input_value_1.Text = "a oldal:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal:";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


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
                        lbl_input_value_1.Text = "a oldal:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal:";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "Magasság:";
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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


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
                        lbl_input_value_1.Text = "a oldal:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "e átló:";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "f átló:";
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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.rombusz;
                        pctbx_alakzat.Width = 400;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y-10);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n-Rombusz kerülete: T = ef/2 = a2 sin α \n  -Rombusz területe: K = 4a ";

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
                        lbl_input_value_1.Text = "a oldal:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "b oldal:";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "e átló:";
                        lbl_mertekegyseg_4.Text = "Cm";
                        lbl_input_value_4.Text = "f átló:";
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

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


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
                        lbl_input_value_1.Text = "sugár:";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;

                        lbl_output_measure_1.Text = "Cm\xB2";
                        lbl_output_measure_2.Text = "Cm";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


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
                        lbl_input_value_1.Text = "sugár:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "Testmagasság:";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        lbl_input_value_2.Visible = true;
                        txtbx_input_value_2.Visible = true;
                        lbl_mertekegyseg_2.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;

                        lbl_output_measure_1.Text = "Cm\xB3";
                        lbl_output_measure_2.Text = "Cm\xB2";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.henger;
                        pctbx_alakzat.Width = 200;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 510, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Henger felszíne: A = 2πr (r + m) \n -Henger térfogata: V = πr2 m";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;



                    }
                    break;
                case "Gúla":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "a oldal:";
                        lbl_mertekegyseg_2.Text = "Cm";
                        lbl_input_value_2.Text = "Testmagasság:";
                        lbl_mertekegyseg_3.Text = "Cm";
                        lbl_input_value_3.Text = "Oldalmagasság:";
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

                        lbl_output_measure_1.Text = "Cm\xB3";
                        lbl_output_measure_2.Text = "Cm\xB2";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.gula;
                        pctbx_alakzat.Width = 280;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 470, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Gúla felszíne: A = T + P \n -Gúla térfogata: V = (T m) /3";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                case "Gömb":
                    if (true)
                    {
                        lbl_mertekegyseg_1.Text = "Cm";
                        lbl_input_value_1.Text = "sugár:";
                        lbl_input_value_1.Visible = true;
                        txtbx_input_value_1.Visible = true;
                        lbl_mertekegyseg_1.Visible = true;
                        rchtxtbx_egyenlet.Visible = true;

                        lbl_output_measure_1.Text = "Cm\xB3";
                        lbl_output_measure_2.Text = "Cm\xB2";
                        lbl_output_measure_1.Visible = true;
                        lbl_output_measure_2.Visible = true;


                        pctbx_alakzat.Image = Properties.Resources.gomb;
                        pctbx_alakzat.Width = 280;
                        pctbx_alakzat.Height = 280;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 450, combo_alakzatok.Location.Y);
                        rchtxtbx_egyenlet.Visible = true;
                        rchtxtbx_egyenlet.Text = "\n -Gömb felszíne: A = 4πR2 = πd2 \n -Gömb térfogata: V = (4π /3) R3 = (π /6) d3";

                        lbl_result_1.Visible = true;
                        lbl_result_1.Text = "Térfogat:";
                        lbl_result_2.Visible = true;
                        lbl_result_2.Text = "Felszín:";
                        txtbx_result_1.Visible = true;
                        txtbx_result_2.Visible = true;
                    }
                    break;
                
            }
        }
    }
}
