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
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_alakzatok_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            
            
            int textboxheight = 20;
            int textboxwidth = 100;
            
            switch (alakzat)
            {
                case "Háromszög":
                    for (int i = 0; i < 4; i++)
                    {
                        Label newlabeltriangle = new Label();
                        newlabeltriangle.Location = new Point(combo_alakzatok.Location.X, combo_alakzatok.Location.Y + 180 + i * 30);
                        newlabeltriangle.Height = textboxheight;
                        newlabeltriangle.Width = textboxwidth;
                        newlabeltriangle.Name = "lbl_triangle_" + i;
                        this.Controls.Add(newlabeltriangle);
                        labelek.Add(newlabeltriangle);
                        switch (i)
                        {
                            case 0:
                                newlabeltriangle.Text = "a oldal:";
                                break;
                            case 1:
                                newlabeltriangle.Text = "b oldal:";
                                break;
                            case 2:
                                newlabeltriangle.Text = "c oldal:";
                                break;
                            case 3:
                                newlabeltriangle.Text = "Magasság:";
                                break;
                        }
                        TextBox newtextboxtriangle = new TextBox();
                        newtextboxtriangle.Location = new Point(newlabeltriangle.Location.X+textboxwidth, newlabeltriangle.Location.Y-3);
                        newtextboxtriangle.Height = textboxheight;
                        newtextboxtriangle.Width = textboxwidth;
                        newtextboxtriangle.Name = "txtbx_triangle_" + i;
                        newtextboxtriangle.Text = "Írja be az értéket ";
                        this.Controls.Add(newtextboxtriangle);
                        textboxok.Add(newtextboxtriangle);
                    }
                    pctbx_alakzat.Image = Properties.Resources.triangle;
                    pctbx_alakzat.Width = 400;
                    pctbx_alakzat.Height = 200;
                    pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X+380, combo_alakzatok.Location.Y);
                    pctbx_egyenlet.Visible = true;
                    pctbx_egyenlet.Image = Properties.Resources.triangle;


                    break;
                case "Négyzet":
                    if (true)
                    {
                        Label newlabelsquare = new Label();
                        newlabelsquare.Location = new Point(combo_alakzatok.Location.X, combo_alakzatok.Location.Y + 180 + 30);
                        newlabelsquare.Height = textboxheight;
                        newlabelsquare.Width = textboxwidth;
                        newlabelsquare.Name = "lbl_square";
                        newlabelsquare.Text = "a oldal:";
                        this.Controls.Add(newlabelsquare);

                        TextBox newtextbox = new TextBox();
                        newtextbox.Location = new Point(newlabelsquare.Location.X + textboxwidth, newlabelsquare.Location.Y - 3);
                        newtextbox.Height = textboxheight;
                        newtextbox.Width = textboxwidth;
                        newtextbox.Name = "txtbx_square";
                        newtextbox.Text = "Írja be az értéket ";
                        this.Controls.Add(newtextbox);

                        pctbx_alakzat.Image = Properties.Resources.negyzet;
                        pctbx_alakzat.Width = 300;
                        pctbx_alakzat.Height = 300;
                        pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y);
                        pctbx_egyenlet.Visible = true;
                        pctbx_egyenlet.Image = Properties.Resources.negyzet;
                    }
                        



                    break;
                case "Trapéz":

                    for (int i = 0; i < 5; i++)
                    {
                        Label newlabeltrap = new Label();
                        newlabeltrap.Location = new Point(combo_alakzatok.Location.X, combo_alakzatok.Location.Y + 180 + i * 30);
                        newlabeltrap.Height = textboxheight;
                        newlabeltrap.Width = textboxwidth;
                        newlabeltrap.Name = "lbl_triangle_" + i;
                        this.Controls.Add(newlabeltrap);
                        switch (i)
                        {
                            case 0:
                                newlabeltrap.Text = "a oldal:";
                                break;
                            case 1:
                                newlabeltrap.Text = "b oldal:";
                                break;
                            case 2:
                                newlabeltrap.Text = "c oldal:";
                                break;
                            case 3:
                                newlabeltrap.Text = "d oldal:";
                                break;
                            case 4:
                                newlabeltrap.Text = "Magasság:";
                                break;
                        }
                        TextBox newtextboxtrap = new TextBox();
                        newtextboxtrap.Location = new Point(newlabeltrap.Location.X + textboxwidth, newlabeltrap.Location.Y - 3);
                        newtextboxtrap.Height = textboxheight;
                        newtextboxtrap.Width = textboxwidth;
                        newtextboxtrap.Name = "txtbx_triangle_" + i;
                        newtextboxtrap.Text = "Írja be az értéket ";
                        this.Controls.Add(newtextboxtrap);
                    }
                    pctbx_alakzat.Image = Properties.Resources.trap;
                    pctbx_alakzat.Width = 400;
                    pctbx_alakzat.Height = 200;
                    pctbx_alakzat.Location = new Point(combo_alakzatok.Location.X + 380, combo_alakzatok.Location.Y);
                    pctbx_egyenlet.Visible = true;
                    pctbx_egyenlet.Image = Properties.Resources.trap;
                    break;
                case "Téglalap":
                    break;
                case "Paralelogramma":
                    break;
                case "Rombusz":
                    break;
                case "Deltoid":
                    break;
                case "Kör":
                    break;
                case "Henger":
                    break;
                case "Gúla":
                    break;
                case "Gömb":
                    break;
                
            }
        }
    }
}
