
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.combo_alakzatok = new System.Windows.Forms.ComboBox();
            this.korabbi = new System.Windows.Forms.ListBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_input_value_1 = new System.Windows.Forms.Label();
            this.lbl_input_value_2 = new System.Windows.Forms.Label();
            this.lbl_input_value_3 = new System.Windows.Forms.Label();
            this.lbl_input_value_4 = new System.Windows.Forms.Label();
            this.lbl_input_value_5 = new System.Windows.Forms.Label();
            this.lbl_mertekegyseg_5 = new System.Windows.Forms.Label();
            this.lbl_mertekegyseg_4 = new System.Windows.Forms.Label();
            this.lbl_mertekegyseg_3 = new System.Windows.Forms.Label();
            this.lbl_mertekegyseg_2 = new System.Windows.Forms.Label();
            this.lbl_mertekegyseg_1 = new System.Windows.Forms.Label();
            this.txtbx_result_1 = new System.Windows.Forms.TextBox();
            this.lbl_result_1 = new System.Windows.Forms.Label();
            this.txtbx_result_2 = new System.Windows.Forms.TextBox();
            this.lbl_result_2 = new System.Windows.Forms.Label();
            this.rchtxtbx_egyenlet = new System.Windows.Forms.RichTextBox();
            this.lbl_output_measure_2 = new System.Windows.Forms.Label();
            this.lbl_output_measure_1 = new System.Windows.Forms.Label();
            this.txtbx_input_value_1 = new System.Windows.Forms.NumericUpDown();
            this.txtbx_input_value_2 = new System.Windows.Forms.NumericUpDown();
            this.txtbx_input_value_3 = new System.Windows.Forms.NumericUpDown();
            this.txtbx_input_value_4 = new System.Windows.Forms.NumericUpDown();
            this.txtbx_input_value_5 = new System.Windows.Forms.NumericUpDown();
            this.pctbx_alakzat = new System.Windows.Forms.PictureBox();
            this.lbl_history = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_alakzat)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_alakzatok
            // 
            this.combo_alakzatok.BackColor = System.Drawing.Color.Silver;
            this.combo_alakzatok.DropDownHeight = 150;
            this.combo_alakzatok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.korabbi.BackColor = System.Drawing.Color.DarkSalmon;
            this.korabbi.FormattingEnabled = true;
            this.korabbi.Location = new System.Drawing.Point(420, 343);
            this.korabbi.Name = "korabbi";
            this.korabbi.Size = new System.Drawing.Size(368, 95);
            this.korabbi.TabIndex = 1;
            this.korabbi.Visible = false;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(299, 415);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.Text = "Számítás";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Visible = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_input_value_1
            // 
            this.lbl_input_value_1.AutoSize = true;
            this.lbl_input_value_1.BackColor = System.Drawing.Color.Silver;
            this.lbl_input_value_1.Location = new System.Drawing.Point(12, 274);
            this.lbl_input_value_1.Name = "lbl_input_value_1";
            this.lbl_input_value_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_input_value_1.TabIndex = 6;
            this.lbl_input_value_1.Text = "label1";
            this.lbl_input_value_1.Visible = false;
            // 
            // lbl_input_value_2
            // 
            this.lbl_input_value_2.AutoSize = true;
            this.lbl_input_value_2.BackColor = System.Drawing.Color.Silver;
            this.lbl_input_value_2.Location = new System.Drawing.Point(12, 301);
            this.lbl_input_value_2.Name = "lbl_input_value_2";
            this.lbl_input_value_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_input_value_2.TabIndex = 7;
            this.lbl_input_value_2.Text = "label2";
            this.lbl_input_value_2.Visible = false;
            // 
            // lbl_input_value_3
            // 
            this.lbl_input_value_3.AutoSize = true;
            this.lbl_input_value_3.BackColor = System.Drawing.Color.Silver;
            this.lbl_input_value_3.Location = new System.Drawing.Point(12, 328);
            this.lbl_input_value_3.Name = "lbl_input_value_3";
            this.lbl_input_value_3.Size = new System.Drawing.Size(35, 13);
            this.lbl_input_value_3.TabIndex = 8;
            this.lbl_input_value_3.Text = "label3";
            this.lbl_input_value_3.Visible = false;
            // 
            // lbl_input_value_4
            // 
            this.lbl_input_value_4.AutoSize = true;
            this.lbl_input_value_4.BackColor = System.Drawing.Color.Silver;
            this.lbl_input_value_4.Location = new System.Drawing.Point(12, 358);
            this.lbl_input_value_4.Name = "lbl_input_value_4";
            this.lbl_input_value_4.Size = new System.Drawing.Size(35, 13);
            this.lbl_input_value_4.TabIndex = 9;
            this.lbl_input_value_4.Text = "label4";
            this.lbl_input_value_4.Visible = false;
            // 
            // lbl_input_value_5
            // 
            this.lbl_input_value_5.AutoSize = true;
            this.lbl_input_value_5.BackColor = System.Drawing.Color.Silver;
            this.lbl_input_value_5.Location = new System.Drawing.Point(12, 384);
            this.lbl_input_value_5.Name = "lbl_input_value_5";
            this.lbl_input_value_5.Size = new System.Drawing.Size(35, 13);
            this.lbl_input_value_5.TabIndex = 10;
            this.lbl_input_value_5.Text = "label5";
            this.lbl_input_value_5.Visible = false;
            // 
            // lbl_mertekegyseg_5
            // 
            this.lbl_mertekegyseg_5.AutoSize = true;
            this.lbl_mertekegyseg_5.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mertekegyseg_5.Location = new System.Drawing.Point(211, 385);
            this.lbl_mertekegyseg_5.Name = "lbl_mertekegyseg_5";
            this.lbl_mertekegyseg_5.Size = new System.Drawing.Size(35, 13);
            this.lbl_mertekegyseg_5.TabIndex = 20;
            this.lbl_mertekegyseg_5.Text = "label5";
            this.lbl_mertekegyseg_5.Visible = false;
            // 
            // lbl_mertekegyseg_4
            // 
            this.lbl_mertekegyseg_4.AutoSize = true;
            this.lbl_mertekegyseg_4.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mertekegyseg_4.Location = new System.Drawing.Point(211, 359);
            this.lbl_mertekegyseg_4.Name = "lbl_mertekegyseg_4";
            this.lbl_mertekegyseg_4.Size = new System.Drawing.Size(35, 13);
            this.lbl_mertekegyseg_4.TabIndex = 19;
            this.lbl_mertekegyseg_4.Text = "label4";
            this.lbl_mertekegyseg_4.Visible = false;
            // 
            // lbl_mertekegyseg_3
            // 
            this.lbl_mertekegyseg_3.AutoSize = true;
            this.lbl_mertekegyseg_3.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mertekegyseg_3.Location = new System.Drawing.Point(211, 329);
            this.lbl_mertekegyseg_3.Name = "lbl_mertekegyseg_3";
            this.lbl_mertekegyseg_3.Size = new System.Drawing.Size(35, 13);
            this.lbl_mertekegyseg_3.TabIndex = 18;
            this.lbl_mertekegyseg_3.Text = "label3";
            this.lbl_mertekegyseg_3.Visible = false;
            // 
            // lbl_mertekegyseg_2
            // 
            this.lbl_mertekegyseg_2.AutoSize = true;
            this.lbl_mertekegyseg_2.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mertekegyseg_2.Location = new System.Drawing.Point(211, 302);
            this.lbl_mertekegyseg_2.Name = "lbl_mertekegyseg_2";
            this.lbl_mertekegyseg_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_mertekegyseg_2.TabIndex = 17;
            this.lbl_mertekegyseg_2.Text = "label2";
            this.lbl_mertekegyseg_2.Visible = false;
            // 
            // lbl_mertekegyseg_1
            // 
            this.lbl_mertekegyseg_1.AutoSize = true;
            this.lbl_mertekegyseg_1.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mertekegyseg_1.Location = new System.Drawing.Point(211, 275);
            this.lbl_mertekegyseg_1.Name = "lbl_mertekegyseg_1";
            this.lbl_mertekegyseg_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_mertekegyseg_1.TabIndex = 16;
            this.lbl_mertekegyseg_1.Text = "label1";
            this.lbl_mertekegyseg_1.Visible = false;
            // 
            // txtbx_result_1
            // 
            this.txtbx_result_1.Location = new System.Drawing.Point(362, 272);
            this.txtbx_result_1.Name = "txtbx_result_1";
            this.txtbx_result_1.ReadOnly = true;
            this.txtbx_result_1.Size = new System.Drawing.Size(100, 20);
            this.txtbx_result_1.TabIndex = 22;
            this.txtbx_result_1.Visible = false;
            // 
            // lbl_result_1
            // 
            this.lbl_result_1.AutoSize = true;
            this.lbl_result_1.BackColor = System.Drawing.Color.Silver;
            this.lbl_result_1.Location = new System.Drawing.Point(269, 275);
            this.lbl_result_1.Name = "lbl_result_1";
            this.lbl_result_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_result_1.TabIndex = 21;
            this.lbl_result_1.Text = "label1";
            this.lbl_result_1.Visible = false;
            // 
            // txtbx_result_2
            // 
            this.txtbx_result_2.Location = new System.Drawing.Point(362, 302);
            this.txtbx_result_2.Name = "txtbx_result_2";
            this.txtbx_result_2.ReadOnly = true;
            this.txtbx_result_2.Size = new System.Drawing.Size(100, 20);
            this.txtbx_result_2.TabIndex = 24;
            this.txtbx_result_2.Visible = false;
            // 
            // lbl_result_2
            // 
            this.lbl_result_2.AutoSize = true;
            this.lbl_result_2.BackColor = System.Drawing.Color.Silver;
            this.lbl_result_2.Location = new System.Drawing.Point(269, 305);
            this.lbl_result_2.Name = "lbl_result_2";
            this.lbl_result_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_result_2.TabIndex = 23;
            this.lbl_result_2.Text = "label1";
            this.lbl_result_2.Visible = false;
            // 
            // rchtxtbx_egyenlet
            // 
            this.rchtxtbx_egyenlet.BackColor = System.Drawing.Color.DarkSalmon;
            this.rchtxtbx_egyenlet.Location = new System.Drawing.Point(148, 12);
            this.rchtxtbx_egyenlet.Name = "rchtxtbx_egyenlet";
            this.rchtxtbx_egyenlet.ReadOnly = true;
            this.rchtxtbx_egyenlet.Size = new System.Drawing.Size(238, 60);
            this.rchtxtbx_egyenlet.TabIndex = 25;
            this.rchtxtbx_egyenlet.Text = "";
            this.rchtxtbx_egyenlet.Visible = false;
            // 
            // lbl_output_measure_2
            // 
            this.lbl_output_measure_2.AutoSize = true;
            this.lbl_output_measure_2.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_output_measure_2.Location = new System.Drawing.Point(468, 306);
            this.lbl_output_measure_2.Name = "lbl_output_measure_2";
            this.lbl_output_measure_2.Size = new System.Drawing.Size(35, 13);
            this.lbl_output_measure_2.TabIndex = 27;
            this.lbl_output_measure_2.Text = "label2";
            this.lbl_output_measure_2.Visible = false;
            // 
            // lbl_output_measure_1
            // 
            this.lbl_output_measure_1.AutoSize = true;
            this.lbl_output_measure_1.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_output_measure_1.Location = new System.Drawing.Point(468, 279);
            this.lbl_output_measure_1.Name = "lbl_output_measure_1";
            this.lbl_output_measure_1.Size = new System.Drawing.Size(35, 13);
            this.lbl_output_measure_1.TabIndex = 26;
            this.lbl_output_measure_1.Text = "label1";
            this.lbl_output_measure_1.Visible = false;
            // 
            // txtbx_input_value_1
            // 
            this.txtbx_input_value_1.DecimalPlaces = 1;
            this.txtbx_input_value_1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtbx_input_value_1.Location = new System.Drawing.Point(105, 272);
            this.txtbx_input_value_1.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.txtbx_input_value_1.Name = "txtbx_input_value_1";
            this.txtbx_input_value_1.Size = new System.Drawing.Size(100, 20);
            this.txtbx_input_value_1.TabIndex = 28;
            this.txtbx_input_value_1.Visible = false;
            this.txtbx_input_value_1.Enter += new System.EventHandler(this.txtbx_input_value_1_Enter);
            this.txtbx_input_value_1.Leave += new System.EventHandler(this.txtbx_input_value_1_Leave);
            // 
            // txtbx_input_value_2
            // 
            this.txtbx_input_value_2.DecimalPlaces = 1;
            this.txtbx_input_value_2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtbx_input_value_2.Location = new System.Drawing.Point(105, 298);
            this.txtbx_input_value_2.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.txtbx_input_value_2.Name = "txtbx_input_value_2";
            this.txtbx_input_value_2.Size = new System.Drawing.Size(100, 20);
            this.txtbx_input_value_2.TabIndex = 29;
            this.txtbx_input_value_2.Visible = false;
            this.txtbx_input_value_2.Enter += new System.EventHandler(this.txtbx_input_value_2_Enter_1);
            this.txtbx_input_value_2.Leave += new System.EventHandler(this.txtbx_input_value_2_Leave_1);
            // 
            // txtbx_input_value_3
            // 
            this.txtbx_input_value_3.DecimalPlaces = 1;
            this.txtbx_input_value_3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtbx_input_value_3.Location = new System.Drawing.Point(105, 326);
            this.txtbx_input_value_3.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.txtbx_input_value_3.Name = "txtbx_input_value_3";
            this.txtbx_input_value_3.Size = new System.Drawing.Size(100, 20);
            this.txtbx_input_value_3.TabIndex = 30;
            this.txtbx_input_value_3.Visible = false;
            this.txtbx_input_value_3.Enter += new System.EventHandler(this.txtbx_input_value_3_Enter);
            this.txtbx_input_value_3.Leave += new System.EventHandler(this.txtbx_input_value_3_Leave);
            // 
            // txtbx_input_value_4
            // 
            this.txtbx_input_value_4.DecimalPlaces = 1;
            this.txtbx_input_value_4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtbx_input_value_4.Location = new System.Drawing.Point(105, 352);
            this.txtbx_input_value_4.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.txtbx_input_value_4.Name = "txtbx_input_value_4";
            this.txtbx_input_value_4.Size = new System.Drawing.Size(100, 20);
            this.txtbx_input_value_4.TabIndex = 31;
            this.txtbx_input_value_4.Visible = false;
            this.txtbx_input_value_4.Enter += new System.EventHandler(this.txtbx_input_value_4_Enter);
            this.txtbx_input_value_4.Leave += new System.EventHandler(this.txtbx_input_value_4_Leave);
            // 
            // txtbx_input_value_5
            // 
            this.txtbx_input_value_5.DecimalPlaces = 1;
            this.txtbx_input_value_5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtbx_input_value_5.Location = new System.Drawing.Point(105, 378);
            this.txtbx_input_value_5.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.txtbx_input_value_5.Name = "txtbx_input_value_5";
            this.txtbx_input_value_5.Size = new System.Drawing.Size(100, 20);
            this.txtbx_input_value_5.TabIndex = 32;
            this.txtbx_input_value_5.Visible = false;
            this.txtbx_input_value_5.Enter += new System.EventHandler(this.txtbx_input_value_5_Enter);
            this.txtbx_input_value_5.Leave += new System.EventHandler(this.txtbx_input_value_5_Leave);
            // 
            // pctbx_alakzat
            // 
            this.pctbx_alakzat.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_alakzat.ImageLocation = "";
            this.pctbx_alakzat.Location = new System.Drawing.Point(148, 12);
            this.pctbx_alakzat.Name = "pctbx_alakzat";
            this.pctbx_alakzat.Size = new System.Drawing.Size(640, 307);
            this.pctbx_alakzat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx_alakzat.TabIndex = 2;
            this.pctbx_alakzat.TabStop = false;
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Location = new System.Drawing.Point(555, 328);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(67, 13);
            this.lbl_history.TabIndex = 33;
            this.lbl_history.Text = "Előzmények:";
            this.lbl_history.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.txtbx_input_value_5);
            this.Controls.Add(this.txtbx_input_value_4);
            this.Controls.Add(this.txtbx_input_value_3);
            this.Controls.Add(this.txtbx_input_value_2);
            this.Controls.Add(this.txtbx_input_value_1);
            this.Controls.Add(this.lbl_output_measure_2);
            this.Controls.Add(this.lbl_output_measure_1);
            this.Controls.Add(this.rchtxtbx_egyenlet);
            this.Controls.Add(this.txtbx_result_2);
            this.Controls.Add(this.lbl_result_2);
            this.Controls.Add(this.txtbx_result_1);
            this.Controls.Add(this.lbl_result_1);
            this.Controls.Add(this.lbl_mertekegyseg_5);
            this.Controls.Add(this.lbl_mertekegyseg_4);
            this.Controls.Add(this.lbl_mertekegyseg_3);
            this.Controls.Add(this.lbl_mertekegyseg_2);
            this.Controls.Add(this.lbl_mertekegyseg_1);
            this.Controls.Add(this.lbl_input_value_5);
            this.Controls.Add(this.lbl_input_value_4);
            this.Controls.Add(this.lbl_input_value_3);
            this.Controls.Add(this.lbl_input_value_2);
            this.Controls.Add(this.lbl_input_value_1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.pctbx_alakzat);
            this.Controls.Add(this.korabbi);
            this.Controls.Add(this.combo_alakzatok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "TérFelszín számítóka";
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_input_value_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_alakzat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_alakzatok;
        private System.Windows.Forms.ListBox korabbi;
        private System.Windows.Forms.PictureBox pctbx_alakzat;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_input_value_1;
        private System.Windows.Forms.Label lbl_input_value_2;
        private System.Windows.Forms.Label lbl_input_value_3;
        private System.Windows.Forms.Label lbl_input_value_4;
        private System.Windows.Forms.Label lbl_input_value_5;
        private System.Windows.Forms.Label lbl_mertekegyseg_5;
        private System.Windows.Forms.Label lbl_mertekegyseg_4;
        private System.Windows.Forms.Label lbl_mertekegyseg_3;
        private System.Windows.Forms.Label lbl_mertekegyseg_2;
        private System.Windows.Forms.Label lbl_mertekegyseg_1;
        private System.Windows.Forms.TextBox txtbx_result_1;
        private System.Windows.Forms.Label lbl_result_1;
        private System.Windows.Forms.TextBox txtbx_result_2;
        private System.Windows.Forms.Label lbl_result_2;
        private System.Windows.Forms.RichTextBox rchtxtbx_egyenlet;
        private System.Windows.Forms.Label lbl_output_measure_2;
        private System.Windows.Forms.Label lbl_output_measure_1;
        private System.Windows.Forms.NumericUpDown txtbx_input_value_1;
        private System.Windows.Forms.NumericUpDown txtbx_input_value_2;
        private System.Windows.Forms.NumericUpDown txtbx_input_value_3;
        private System.Windows.Forms.NumericUpDown txtbx_input_value_4;
        private System.Windows.Forms.NumericUpDown txtbx_input_value_5;
        private System.Windows.Forms.Label lbl_history;
    }
}

