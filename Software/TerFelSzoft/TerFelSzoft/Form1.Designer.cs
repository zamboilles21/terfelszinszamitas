
namespace TerFelSzoft
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_alakzatok = new System.Windows.Forms.ComboBox();
            this.korabbi = new System.Windows.Forms.ListBox();
            this.pctbx_alakzat = new System.Windows.Forms.PictureBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.pctbx_egyenlet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_alakzat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_egyenlet)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_alakzatok
            // 
            this.combo_alakzatok.DropDownHeight = 150;
            this.combo_alakzatok.DropDownWidth = 130;
            this.combo_alakzatok.FormattingEnabled = true;
            this.combo_alakzatok.IntegralHeight = false;
            this.combo_alakzatok.ItemHeight = 13;
            this.combo_alakzatok.Items.AddRange(new object[] {
            "Háromszög",
            "Négyzet",
            "Trapéz",
            "Téglalap",
            "Paralelogramma",
            "Rombusz",
            "Deltoid",
            "Kör",
            "Henger",
            "Gúla",
            "Gömb"});
            this.combo_alakzatok.Location = new System.Drawing.Point(12, 12);
            this.combo_alakzatok.MaxDropDownItems = 12;
            this.combo_alakzatok.Name = "combo_alakzatok";
            this.combo_alakzatok.Size = new System.Drawing.Size(130, 21);
            this.combo_alakzatok.TabIndex = 0;
            this.combo_alakzatok.SelectedIndexChanged += new System.EventHandler(this.combo_alakzatok_SelectedIndexChanged);
            // 
            // korabbi
            // 
            this.korabbi.FormattingEnabled = true;
            this.korabbi.Location = new System.Drawing.Point(668, 343);
            this.korabbi.Name = "korabbi";
            this.korabbi.Size = new System.Drawing.Size(120, 95);
            this.korabbi.TabIndex = 1;
            // 
            // pctbx_alakzat
            // 
            this.pctbx_alakzat.ImageLocation = "";
            this.pctbx_alakzat.Location = new System.Drawing.Point(148, 12);
            this.pctbx_alakzat.Name = "pctbx_alakzat";
            this.pctbx_alakzat.Size = new System.Drawing.Size(640, 307);
            this.pctbx_alakzat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx_alakzat.TabIndex = 2;
            this.pctbx_alakzat.TabStop = false;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(362, 415);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Számítás";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // pctbx_egyenlet
            // 
            this.pctbx_egyenlet.Location = new System.Drawing.Point(149, 13);
            this.pctbx_egyenlet.Name = "pctbx_egyenlet";
            this.pctbx_egyenlet.Size = new System.Drawing.Size(171, 154);
            this.pctbx_egyenlet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx_egyenlet.TabIndex = 5;
            this.pctbx_egyenlet.TabStop = false;
            this.pctbx_egyenlet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctbx_egyenlet);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.pctbx_alakzat);
            this.Controls.Add(this.korabbi);
            this.Controls.Add(this.combo_alakzatok);
            this.Name = "Form1";
            this.Text = "TérFelszín számítóka";
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_alakzat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_egyenlet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_alakzatok;
        private System.Windows.Forms.ListBox korabbi;
        private System.Windows.Forms.PictureBox pctbx_alakzat;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.PictureBox pctbx_egyenlet;
    }
}

