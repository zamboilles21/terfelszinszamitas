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
        
        static string alakzat = "";
        public Form1()
        {
            InitializeComponent();
            
            //Kezdő image amíg nincs kiválkasztva alakzat
            pctbx_alakzat.Image = Properties.Resources.modern_art;
            //Kiválasztott test egyenleteit tároló richtextbox elemeinek középre helyezése
            rchtxtbx_egyenlet.SelectionAlignment = HorizontalAlignment.Center;

        }

        //Számítás gomb lenyomása
        private void btn_calc_Click(object sender, EventArgs e)
        {



            // Textbox csak számot fogad el
            bool notdouble_input_1 = txtbx_input_value_1.Text.Any(Char.IsDigit);
            bool notdouble_input_2 = txtbx_input_value_1.Text.Any(Char.IsDigit);
            bool notdouble_input_3 = txtbx_input_value_1.Text.Any(Char.IsDigit);
            bool notdouble_input_4 = txtbx_input_value_1.Text.Any(Char.IsDigit);
            bool notdouble_input_5 = txtbx_input_value_1.Text.Any(Char.IsDigit);
            
            if (!notdouble_input_1||!notdouble_input_2||!notdouble_input_3||!notdouble_input_4||!notdouble_input_5)
            {
                MessageBox.Show("Nem adott meg minden szükséges adatot");
            }
            else
            {
                double input_value_1 = 1;
                double input_value_2 = 1;
                double input_value_3 = 1;
                double input_value_4 = 1;
                double input_value_5 = 1;


                if (!txtbx_input_value_1.Text.Contains("-")&& txtbx_input_value_1.Text != "")
                {
                    input_value_1 = Convert.ToDouble(txtbx_input_value_1.Text);
                }
                
                if (!txtbx_input_value_2.Text.Contains("-") && txtbx_input_value_2.Text != "")
                {
                    input_value_2 = Convert.ToDouble(txtbx_input_value_2.Text);
                }
                if (!txtbx_input_value_3.Text.Contains("-") && txtbx_input_value_3.Text != "")
                {
                    input_value_3 = Convert.ToDouble(txtbx_input_value_3.Text);
                }
                if (!txtbx_input_value_4.Text.Contains("-") && txtbx_input_value_4.Text != "")
                {
                    input_value_4 = Convert.ToDouble(txtbx_input_value_4.Text);
                }
                if (!txtbx_input_value_5.Text.Contains("-") && txtbx_input_value_5.Text != "")
                {
                    input_value_5 = Convert.ToDouble(txtbx_input_value_5.Text);
                }

                //Alakzat kiválasztása, műveletek elvégése, kiírása és lementése az előzmények alatti korabbi listboxba
                    switch (alakzat)
                    {
                        case "Háromszög":

                        if (input_value_1==0|| input_value_2 == 0 || input_value_3 == 0 || input_value_4 == 0||!notdouble_input_1 || !notdouble_input_2 || !notdouble_input_3 || !notdouble_input_4)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_tri = input_value_1;
                            double boldal_tri = input_value_2;
                            double coldal_tri = input_value_3;
                            double magassag_tri = input_value_4;
                            txtbx_result_1.Text = ((aoldal_tri * magassag_tri) / 2).ToString("0.00");
                            txtbx_result_2.Text = (aoldal_tri + boldal_tri + coldal_tri).ToString("0.00");

                            korabbi.Items.Add("Háromszög: a oldal: " + aoldal_tri + "cm b oldal: " + boldal_tri + "cm c oldal: " + coldal_tri + "cm magasság: " + magassag_tri + "cm");
                            korabbi.Items.Add("Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");
                        }


                            

                            break;
                        case "Négyzet":

                        if (input_value_1 == 0 || !notdouble_input_1)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_square = input_value_1;
                            txtbx_result_2.Text = (4 * aoldal_square).ToString("0.00");
                            txtbx_result_1.Text = (aoldal_square * aoldal_square).ToString("0.00");

                            korabbi.Items.Add("Négyzet: a oldal: " + aoldal_square + "cm Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");
                        }

                            

                            break;
                        case "Téglalap":

                        if (input_value_1 == 0 || !notdouble_input_1|| input_value_2 == 0 || !notdouble_input_2)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_brick = input_value_1;
                            double boldal_brick = input_value_2;

                            txtbx_result_2.Text = ((2 * aoldal_brick) + (2 * boldal_brick)).ToString("0.00");
                            txtbx_result_1.Text = (aoldal_brick * boldal_brick).ToString("0.00");

                            korabbi.Items.Add("Téglalap: a oldal: " + aoldal_brick + "cm" + " b oldal: " + boldal_brick + "cm Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");

                        }


                        break;
                        case "Kör":

                        if (input_value_1 == 0 || !notdouble_input_1)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double kor_sugar = input_value_1;

                            txtbx_result_2.Text = (2 * Math.PI * kor_sugar).ToString("0.00");
                            txtbx_result_1.Text = ((kor_sugar * kor_sugar) * Math.PI).ToString("0.00");

                            korabbi.Items.Add("Kör: sugár: " + kor_sugar + "cm Kerület: " + txtbx_result_2.Text + "cm Terület" + txtbx_result_1.Text + "cm\xB2");
                        }


                            

                            break;
                        case "Rombusz":

                        if (input_value_1 == 0 || !notdouble_input_1 || input_value_2 == 0 || !notdouble_input_2|| input_value_3 == 0 || !notdouble_input_3 )
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_rom = input_value_1;
                            double eatlo_rom = input_value_2;
                            double fatlo_rom = input_value_3;

                            if (aoldal_rom == 0)
                            {

                                txtbx_result_2.Text = (2 * (Math.Sqrt((Math.Pow(eatlo_rom, 2) + (Math.Pow(fatlo_rom, 2)))))).ToString("0.00");
                            }
                            else
                            {
                                txtbx_result_2.Text = (4 * aoldal_rom).ToString("0.00");

                            }

                            korabbi.Items.Add("Rombusz: a oldal: " + aoldal_rom + "cm e átló: " + eatlo_rom + "cm f átló: " + fatlo_rom + "cm");
                            korabbi.Items.Add("Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");

                            txtbx_result_1.Text = ((eatlo_rom * fatlo_rom) / 2).ToString("0.00");
                        }


                            
                            break;
                        case "Deltoid":

                        if (input_value_1 == 0 || input_value_2 == 0 || input_value_3 == 0 || input_value_4 == 0 || !notdouble_input_1 || !notdouble_input_2 || !notdouble_input_3 || !notdouble_input_4)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_del = input_value_1;
                            double boldal_del = input_value_2;
                            double eatlo_del = input_value_3;
                            double fatlo_del = input_value_4;

                            txtbx_result_2.Text = ((aoldal_del + boldal_del) * 2).ToString("0.00");
                            txtbx_result_1.Text = ((eatlo_del * fatlo_del) / 2).ToString("0.00");


                            korabbi.Items.Add("Deltoid: a oldal: " + aoldal_del + "cm b oldal: " + boldal_del + "cm e átló: " + eatlo_del + "cm f átló: " + fatlo_del + "cm");
                            korabbi.Items.Add("Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");
                        }

                            
                            break;
                        case "Paralelogramma":

                        if (input_value_1 == 0 || !notdouble_input_1 || input_value_2 == 0 || !notdouble_input_2 || input_value_3 == 0 || !notdouble_input_3)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_par = input_value_1;
                            double boldal_par = input_value_2;
                            double magassag_par = input_value_3;

                            txtbx_result_2.Text = ((aoldal_par + boldal_par) * 2).ToString("0.00");
                            txtbx_result_1.Text = (aoldal_par * magassag_par).ToString("0.00");

                            korabbi.Items.Add("Paralelogramma: a oldal: " + aoldal_par + "cm b oldal: " + boldal_par + "cm magasság: " + magassag_par + "cm");
                            korabbi.Items.Add("Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");
                        }


                            
                            break;
                        case "Trapéz":

                        if (input_value_1 == 0 || !notdouble_input_1 || input_value_2 == 0 || !notdouble_input_2 || input_value_3 == 0 || !notdouble_input_3|| input_value_4 == 0 || !notdouble_input_4 || input_value_5 == 0 || !notdouble_input_5)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double aoldal_trap = input_value_1;
                            double boldal_trap = input_value_2;
                            double coldal_trap = input_value_3;
                            double doldal_trap = input_value_4;
                            double magassag_trap = input_value_5;

                            txtbx_result_2.Text = (aoldal_trap + boldal_trap + coldal_trap + doldal_trap).ToString("0.00");
                            txtbx_result_1.Text = ((aoldal_trap + coldal_trap) / 2 * magassag_trap).ToString("0.00");

                            korabbi.Items.Add("Trapéz: a oldal: " + aoldal_trap + "cm b oldal: " + boldal_trap + "cm c oldal: " + coldal_trap + "cm d oldal: " + doldal_trap + "cm magasság: " + magassag_trap + "cm");
                            korabbi.Items.Add("Kerület: " + txtbx_result_2.Text + "cm Terület: " + txtbx_result_1.Text + "cm\xB2");
                        }

                            
                            break;
                        case "Gúla":

                        if (input_value_1 == 0 || !notdouble_input_1 || input_value_2 == 0 || !notdouble_input_2 || input_value_3 == 0 || !notdouble_input_3)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double gula_aoldal = input_value_1;
                            double gula_testmagassag = input_value_2;
                            double gula_oldalmagassag = input_value_3;

                            txtbx_result_1.Text = ((gula_testmagassag * Math.Pow(gula_aoldal, 2)) / 3).ToString("0.00");
                            txtbx_result_2.Text = (((4*gula_aoldal*gula_oldalmagassag)/2)+ Math.Pow(gula_aoldal,2)).ToString("0.00")   ;                                    //(Math.Pow(gula_aoldal, 2) + ((gula_aoldal * gula_oldalmagassag) / 2)).ToString("0.00");

                            korabbi.Items.Add("Gúla: a oldal: " + gula_aoldal + "cm testmagasság: " + gula_testmagassag + "cm oldalmagasság: " + gula_oldalmagassag + "cm");
                            korabbi.Items.Add("Felszín: " + txtbx_result_2.Text + "cm\xB2 Térfogat: " + txtbx_result_1.Text + "cm\xB3");
                        }

                            
                            break;
                        case "Gömb":

                        if (input_value_1 == 0 || !notdouble_input_1)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double gomb_sugar = input_value_1;

                            txtbx_result_1.Text = (((Math.PI * (Math.Pow(gomb_sugar, 3))) / 3) * 4).ToString("0.00");
                            txtbx_result_2.Text = (4 * Math.PI * Math.Pow(gomb_sugar, 2)).ToString("0.00");

                            korabbi.Items.Add("Gömb: sugár: " + gomb_sugar + "cm");
                            korabbi.Items.Add("Felszín: " + txtbx_result_2.Text + "cm\xB2 Térfogat: " + txtbx_result_1.Text + "cm\xB3");
                        }

                            


                            
                            break;
                        case "Henger":

                        if (input_value_1 == 0 || !notdouble_input_1 || input_value_2 == 0 || !notdouble_input_2)
                        {
                            MessageBox.Show("Nem adott meg minden szükséges adatot");
                        }
                        else
                        {
                            double henger_sugar = input_value_1;
                            double henger_magassag = input_value_2;

                            txtbx_result_1.Text = (((Math.PI * (henger_sugar * henger_sugar))) * henger_magassag).ToString("0.00");
                            txtbx_result_2.Text = (((Math.PI * 2) * henger_sugar) * (henger_sugar + henger_magassag)).ToString("0.00");

                            korabbi.Items.Add("Gömb: sugár: " + henger_sugar + "cm magasság: " + henger_magassag);
                            korabbi.Items.Add("Felszín: " + txtbx_result_2.Text + "cm\xB2 Térfogat: " + txtbx_result_1.Text + "cm\xB3");
                        }


                            
                            break;
                    }
                


                
            }
            //korabbi listbox csak akkor jelenik meg ha nem üres
            if (korabbi.Items.Count>0)
            {
                korabbi.Visible = true;
                lbl_history.Visible = true;
            }
            



        }

        //Alakzat választás
        private void combo_alakzatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_calc.Visible = true;
            
            for (int i = 0; i < 10; i++)
            {
                pctbx_alakzat.SendToBack();
            }
            //Kezdő értékek nullázása
            {
                txtbx_input_value_1.Value = 0;
                txtbx_input_value_2.Value = 0;
                txtbx_input_value_3.Value = 0;
                txtbx_input_value_4.Value = 0;
                txtbx_input_value_5.Value = 0;
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
            }
            alakzat = combo_alakzatok.SelectedItem.ToString();
            
            makeinputfields();
        }

        //A kiválasztott alakzathoz tartozó mezők, szövegek és kép megjelenítése
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


                        pctbx_alakzat.Image = Properties.Resources.kor1;
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

        //Kiválasztott alakzat kiválasztott oldalának kiemelése 
        private void txtbx_input_value_1_Enter(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":

                    pctbx_alakzat.Image = Properties.Resources.triangle_aoldal;

                    break;
                case "Négyzet":
                    pctbx_alakzat.Image = Properties.Resources.negyzet_aoldal;
                    break;
                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap_aoldal;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid_aoldal;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz_aoldal;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_aoldal;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel_aoldal;
                    break;
                case "Kör":
                    pctbx_alakzat.Image = Properties.Resources.kor_sugar;
                    break;
                case "Gömb":
                    pctbx_alakzat.Image = Properties.Resources.gomb_sugar;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger_sugar;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula_aoldal;
                    break;
            }
        }
        private void txtbx_input_value_1_Leave(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    break;
                case "Négyzet":
                    pctbx_alakzat.Image = Properties.Resources.negyzet;
                    break;
                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_water;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel;
                    break;
                case "Kör":
                    pctbx_alakzat.Image = Properties.Resources.kor1;

                    break;
                case "Gömb":
                    pctbx_alakzat.Image = Properties.Resources.gomb;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula;
                    break;

            }
        }

        private void txtbx_input_value_2_Enter_1(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":

                    pctbx_alakzat.Image = Properties.Resources.triangle_boldal;

                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap_boldal;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid_boldal;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz_eatlo;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_boldal;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel_boldal;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger_testmagas;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula_testmag;
                    break;
            }
        }

        private void txtbx_input_value_2_Leave_1(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_water;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula;
                    break;

            }
        }

        private void txtbx_input_value_3_Enter(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":

                    pctbx_alakzat.Image = Properties.Resources.triangle_coldal;

                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap_coldal;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid_eatlo;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz_fatlo;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel_magassag;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula_aoldalmag;
                    break;
            }
        }

        private void txtbx_input_value_3_Leave(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_water;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula;
                    break;

            }
        }

        private void txtbx_input_value_4_Enter(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":

                    pctbx_alakzat.Image = Properties.Resources.triangle_cmagassag;

                    break;
                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap_doldal;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid_fatlo;
                    break;
            }
        }

        private void txtbx_input_value_4_Leave(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_water;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula;
                    break;

            }
        }

        private void txtbx_input_value_5_Enter(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                
                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap_magassag;
                    break;
            }
        }

        private void txtbx_input_value_5_Leave(object sender, EventArgs e)
        {
            switch (alakzat)
            {
                case "Háromszög":
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    break;

                case "Trapéz":
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    break;
                case "Deltoid":
                    pctbx_alakzat.Image = Properties.Resources.deltoid;
                    break;
                case "Rombusz":
                    pctbx_alakzat.Image = Properties.Resources.rombusz;
                    break;
                case "Téglalap":
                    pctbx_alakzat.Image = Properties.Resources.tegla_water;
                    break;
                case "Paralelogramma":
                    pctbx_alakzat.Image = Properties.Resources.paralel;
                    break;
                case "Henger":
                    pctbx_alakzat.Image = Properties.Resources.henger;
                    break;
                case "Gúla":
                    pctbx_alakzat.Image = Properties.Resources.gula;
                    break;

            }
        }
    }
}
