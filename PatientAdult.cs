using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lista5
{
    public partial class PatientAdult : UserControl
    {
        private AppointemntAdult a1;
        private static PatientAdult _instance;
        private List<string> _teeth = new List<string>();
        public static PatientAdult Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new PatientAdult();
                return _instance;
            }
        }

        public PatientAdult()
        {
            InitializeComponent();
        }

        public void btn_enterA_Click(object sender, EventArgs e)
        {
            a1 = new AppointemntAdult(tb_personNameA.Text, tb_lastNamepersonA.Text, tb_peselPersonA.Text ,tb_phonNo.Text,tb_nameA.Text, tb_lastnameA.Text, Convert.ToDateTime(dtp_bhA.Value), tb_cityA.Text, tb_streetA.Text, tb_houseNoA.Text, tb_peselA.Text, Convert.ToDateTime(dtp_apA.Value), tb_apHourA.Text, cb_yesNoA.Text, (Bitmap)pictureBox2.Image, _teeth, cb_points.Text);

            WriteInfo(a1);
            pictureBox1.Image = a1.Photo;
            bool found = false;
            foreach( var patient in Form1.commonList )
            {
                if (patient == a1)
                {
                    found = true;
                    MessageBox.Show("Ten PESEL już istnieje", "Uwaga!");
                    break;
                }
            }
            if (found == false)
            {
                Form1.commonList.Add(a1);
            }
            _teeth.Clear();
            pictureBox2.Image = null;
        }

        public void WriteInfo(Patient a)
        {
            List<string> info2 = a.GetInfo();
            foreach (var appointemntAdult in info2)
            {
                listBox1.Items.Add(appointemntAdult);

            }
            listBox1.Items.Add("");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel_personA.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel_personA.Visible = false;
            tb_personNameA.Text = " - ";
            tb_lastNamepersonA.Text = " - ";
            tb_peselPersonA.Text = " - ";
        }

        private void PatientAdult_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            _teeth.Add(tb_treatmentA.Text);

        }

        private void btn_photoA_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(openFileDialog1.OpenFile());
                pictureBox2.Image = f;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            tb_personNameA.Text = "Bartek";
            tb_lastNamepersonA.Text = "Nowak";
            tb_peselPersonA.Text = "12124545803";
            tb_phonNo.Text = "503288797";
            tb_nameA.Text = "Magda";
            tb_lastnameA.Text = "Nowak";
            Convert.ToDateTime(dtp_bhA.Value);
            tb_cityA.Text = "Katowice";
            tb_streetA.Text = "Piastowaska";
            tb_houseNoA.Text = "2a";
            tb_peselA.Text = "21252363031";
            Convert.ToDateTime(dtp_apA.Value);
            tb_apHourA.Text = "16:15";
            cb_yesNoA.Text = "Nie";
             cb_points.Text = "Lakierowanie";
            tb_treatmentA.Text = "Lewa górna 6";
            pictureBox2.Image = Image.FromFile(@"C:\Users\Użytkownik\Desktop\C#\zdj\pacjent.jpg");
        }
    }
}
