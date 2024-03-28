namespace lista5
{
    partial class PatientAdult
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nameA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_points = new System.Windows.Forms.ComboBox();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_photoA = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.panel_personA = new System.Windows.Forms.Panel();
            this.tb_peselPersonA = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_lastNamepersonA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_personNameA = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_apHourA = new System.Windows.Forms.MaskedTextBox();
            this.tb_phonNo = new System.Windows.Forms.MaskedTextBox();
            this.tb_peselA = new System.Windows.Forms.MaskedTextBox();
            this.cb_yesNoA = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_enterA = new System.Windows.Forms.Button();
            this.tb_treatmentA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_apA = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_houseNoA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_streetA = new System.Windows.Forms.TextBox();
            this.tb_cityA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_bhA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_lastnameA = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_personA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // tb_nameA
            // 
            this.tb_nameA.Location = new System.Drawing.Point(47, 3);
            this.tb_nameA.Name = "tb_nameA";
            this.tb_nameA.Size = new System.Drawing.Size(158, 23);
            this.tb_nameA.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_points);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_photoA);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.panel_personA);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tb_apHourA);
            this.panel1.Controls.Add(this.tb_phonNo);
            this.panel1.Controls.Add(this.tb_peselA);
            this.panel1.Controls.Add(this.cb_yesNoA);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_enterA);
            this.panel1.Controls.Add(this.tb_treatmentA);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtp_apA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_houseNoA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_streetA);
            this.panel1.Controls.Add(this.tb_cityA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_bhA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_lastnameA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_nameA);
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 572);
            this.panel1.TabIndex = 3;
            // 
            // cb_points
            // 
            this.cb_points.FormattingEnabled = true;
            this.cb_points.Items.AddRange(new object[] {
            "Wyrywanie Zęba (z znieczuleniem i opatrunkiem)",
            "Piaskowanie",
            "Lakierowanie",
            "Czyszczenie Kieszonek"});
            this.cb_points.Location = new System.Drawing.Point(12, 374);
            this.cb_points.Name = "cb_points";
            this.cb_points.Size = new System.Drawing.Size(171, 24);
            this.cb_points.TabIndex = 0;
            // 
            // btn_fill
            // 
            this.btn_fill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btn_fill.Location = new System.Drawing.Point(418, 471);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(160, 23);
            this.btn_fill.TabIndex = 48;
            this.btn_fill.Text = "Uzupełnij";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_photoA
            // 
            this.btn_photoA.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btn_photoA.Location = new System.Drawing.Point(152, 472);
            this.btn_photoA.Name = "btn_photoA";
            this.btn_photoA.Size = new System.Drawing.Size(106, 23);
            this.btn_photoA.TabIndex = 49;
            this.btn_photoA.Text = "Wybierz zdjęcie";
            this.btn_photoA.UseVisualStyleBackColor = true;
            this.btn_photoA.Click += new System.EventHandler(this.btn_photoA_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(7, 454);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Zdjecie rendgenu:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 92);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(160, 420);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 42;
            this.bt_add.Text = "Dodaj";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // panel_personA
            // 
            this.panel_personA.Controls.Add(this.tb_peselPersonA);
            this.panel_personA.Controls.Add(this.label19);
            this.panel_personA.Controls.Add(this.tb_lastNamepersonA);
            this.panel_personA.Controls.Add(this.label18);
            this.panel_personA.Controls.Add(this.tb_personNameA);
            this.panel_personA.Controls.Add(this.label17);
            this.panel_personA.Location = new System.Drawing.Point(12, 229);
            this.panel_personA.Name = "panel_personA";
            this.panel_personA.Size = new System.Drawing.Size(458, 69);
            this.panel_personA.TabIndex = 41;
            this.panel_personA.Visible = false;
            this.panel_personA.VisibleChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tb_peselPersonA
            // 
            this.tb_peselPersonA.Location = new System.Drawing.Point(44, 37);
            this.tb_peselPersonA.Mask = "00000000000";
            this.tb_peselPersonA.Name = "tb_peselPersonA";
            this.tb_peselPersonA.Size = new System.Drawing.Size(152, 23);
            this.tb_peselPersonA.TabIndex = 37;
            this.tb_peselPersonA.ValidatingType = typeof(int);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "PESEL:";
            // 
            // tb_lastNamepersonA
            // 
            this.tb_lastNamepersonA.Location = new System.Drawing.Point(254, 8);
            this.tb_lastNamepersonA.Name = "tb_lastNamepersonA";
            this.tb_lastNamepersonA.Size = new System.Drawing.Size(150, 23);
            this.tb_lastNamepersonA.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(185, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Nazwisko:";
            // 
            // tb_personNameA
            // 
            this.tb_personNameA.Location = new System.Drawing.Point(44, 8);
            this.tb_personNameA.Name = "tb_personNameA";
            this.tb_personNameA.Size = new System.Drawing.Size(126, 23);
            this.tb_personNameA.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Imie:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(381, 208);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "nie";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 208);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 20);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tak";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(319, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Osoba upoważniona do informacji medycznych pacjenta:";
            // 
            // tb_apHourA
            // 
            this.tb_apHourA.Location = new System.Drawing.Point(436, 318);
            this.tb_apHourA.Mask = "00:00";
            this.tb_apHourA.Name = "tb_apHourA";
            this.tb_apHourA.Size = new System.Drawing.Size(130, 23);
            this.tb_apHourA.TabIndex = 37;
            this.tb_apHourA.ValidatingType = typeof(System.DateTime);
            // 
            // tb_phonNo
            // 
            this.tb_phonNo.Location = new System.Drawing.Point(61, 89);
            this.tb_phonNo.Mask = "000000000";
            this.tb_phonNo.Name = "tb_phonNo";
            this.tb_phonNo.Size = new System.Drawing.Size(121, 23);
            this.tb_phonNo.TabIndex = 36;
            this.tb_phonNo.ValidatingType = typeof(int);
            // 
            // tb_peselA
            // 
            this.tb_peselA.Location = new System.Drawing.Point(47, 32);
            this.tb_peselA.Mask = "00000000000";
            this.tb_peselA.Name = "tb_peselA";
            this.tb_peselA.Size = new System.Drawing.Size(152, 23);
            this.tb_peselA.TabIndex = 35;
            this.tb_peselA.ValidatingType = typeof(int);
            // 
            // cb_yesNoA
            // 
            this.cb_yesNoA.FormattingEnabled = true;
            this.cb_yesNoA.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.cb_yesNoA.Location = new System.Drawing.Point(107, 344);
            this.cb_yesNoA.Name = "cb_yesNoA";
            this.cb_yesNoA.Size = new System.Drawing.Size(63, 24);
            this.cb_yesNoA.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nr. Tel.:";
            // 
            // btn_enterA
            // 
            this.btn_enterA.Location = new System.Drawing.Point(418, 503);
            this.btn_enterA.Name = "btn_enterA";
            this.btn_enterA.Size = new System.Drawing.Size(160, 26);
            this.btn_enterA.TabIndex = 25;
            this.btn_enterA.Text = "Zatwierdż";
            this.btn_enterA.UseVisualStyleBackColor = true;
            this.btn_enterA.Click += new System.EventHandler(this.btn_enterA_Click);
            // 
            // tb_treatmentA
            // 
            this.tb_treatmentA.Location = new System.Drawing.Point(9, 420);
            this.tb_treatmentA.Name = "tb_treatmentA";
            this.tb_treatmentA.Size = new System.Drawing.Size(145, 23);
            this.tb_treatmentA.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Zęby do leczenie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Refundowane:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Godz. Wizyty:";
            // 
            // dtp_apA
            // 
            this.dtp_apA.Location = new System.Drawing.Point(90, 318);
            this.dtp_apA.Name = "dtp_apA";
            this.dtp_apA.Size = new System.Drawing.Size(237, 23);
            this.dtp_apA.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "DataWizyty:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Wizyta:";
            // 
            // tb_houseNoA
            // 
            this.tb_houseNoA.Location = new System.Drawing.Point(370, 171);
            this.tb_houseNoA.Name = "tb_houseNoA";
            this.tb_houseNoA.Size = new System.Drawing.Size(100, 23);
            this.tb_houseNoA.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nr. Domu/Mieszkania:";
            // 
            // tb_streetA
            // 
            this.tb_streetA.Location = new System.Drawing.Point(96, 171);
            this.tb_streetA.Name = "tb_streetA";
            this.tb_streetA.Size = new System.Drawing.Size(132, 23);
            this.tb_streetA.TabIndex = 12;
            // 
            // tb_cityA
            // 
            this.tb_cityA.Location = new System.Drawing.Point(96, 142);
            this.tb_cityA.Name = "tb_cityA";
            this.tb_cityA.Size = new System.Drawing.Size(132, 23);
            this.tb_cityA.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ulica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Miejscowość:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Miejsce Zamieszkania:";
            // 
            // dtp_bhA
            // 
            this.dtp_bhA.Location = new System.Drawing.Point(107, 60);
            this.dtp_bhA.Name = "dtp_bhA";
            this.dtp_bhA.Size = new System.Drawing.Size(236, 23);
            this.dtp_bhA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Urodzenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PESEL:";
            // 
            // tb_lastnameA
            // 
            this.tb_lastnameA.Location = new System.Drawing.Point(280, 3);
            this.tb_lastnameA.Name = "tb_lastnameA";
            this.tb_lastnameA.Size = new System.Drawing.Size(174, 23);
            this.tb_lastnameA.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(591, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(468, 308);
            this.listBox1.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1066, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "_Wizyta Dorosły__________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 215);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PatientAdult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientAdult";
            this.Size = new System.Drawing.Size(1070, 594);
            this.Load += new System.EventHandler(this.PatientAdult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_personA.ResumeLayout(false);
            this.panel_personA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nameA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_apA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_houseNoA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_streetA;
        private System.Windows.Forms.TextBox tb_cityA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_bhA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_lastnameA;
        private System.Windows.Forms.TextBox tb_treatmentA;
        private System.Windows.Forms.Button btn_enterA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_yesNoA;
        private System.Windows.Forms.MaskedTextBox tb_peselA;
        private System.Windows.Forms.MaskedTextBox tb_phonNo;
        private System.Windows.Forms.MaskedTextBox tb_apHourA;
        private System.Windows.Forms.Panel panel_personA;
        private System.Windows.Forms.MaskedTextBox tb_peselPersonA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_lastNamepersonA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_personNameA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button btn_photoA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_points;
        private System.Windows.Forms.Button btn_fill;
    }
}
