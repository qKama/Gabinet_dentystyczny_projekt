using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lista5
{
    public partial class PatientChild : UserControl
    {
        private AppointemntChild c1;
        private static PatientChild _instance;
        private List<string> _teeth = new List<string>();

        public static PatientChild Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PatientChild();
                return _instance;
            }
        }
        public PatientChild()
        {
            InitializeComponent();
        }

        private void btn_enterC_Click(object sender, EventArgs e)
        {
            c1 = new AppointemntChild(tb_parentsName.Text, tb_parentsLastname.Text, tb_parentsPhonNo.Text, tb_nameC.Text, tb_lastnameC.Text, Convert.ToDateTime(dtp_bhC.Value), tb_cityC.Text, tb_streetC.Text, tb_houseNoC.Text, tb_peselC.Text, Convert.ToDateTime(dtp_apC.Value), tb_apHourC.Text, cb_yesNoC.Text, (Bitmap)pictureBox2.Image, cb_braces.Text, _teeth, cb_points.Text);
            WriteInfo(c1);        
            pictureBox1.Image = c1.Photo;
            bool found = false;
            foreach (var patient in Form1.commonList)
            {
                if (patient == c1)
                {
                    found = true;
                    MessageBox.Show("Ten PESEL już istnieje", "Uwaga!");
                    break;
                }
            }
            if (found == false)
            {
                Form1.commonList.Add(c1);
            }
            pictureBox2.Image = null;
        }

        private void WriteInfo(Patient c)
        {
            List<string> info2 = c.GetInfo();
            foreach (var appointemntChild in info2)
            {
                listBox1.Items.Add(appointemntChild);
            }
            listBox1.Items.Add("");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cb_braces.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cb_braces.Visible = false;
            cb_braces.Text = "nie";
        }

        private void btn_addC_Click(object sender, EventArgs e)
        {
            _teeth.Add(tb_treatmentC.Text);
        }

        private void btn_photoC_Click(object sender, EventArgs e)
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
            tb_parentsName.Text = "Anna";
            tb_parentsLastname.Text = "Kowalska";
            tb_parentsPhonNo.Text = "60298954";
            tb_nameC.Text = "Mikołaj";
            tb_lastnameC.Text = "Kowaski";
            Convert.ToDateTime(dtp_bhC.Value); 
            tb_cityC.Text = "Opole";
            tb_streetC.Text = "Ozimska";
            tb_houseNoC.Text = "45";
            tb_peselC.Text = "03232352120";
            Convert.ToDateTime(dtp_apC.Value); 
            tb_apHourC.Text = "14:00";
            cb_yesNoC.Text = "Tak";
            cb_braces.Text = "nie";
            cb_points.Text = "Lakierowanie";
            tb_treatmentC.Text = "Lewa górna 6";
            pictureBox2.Image = Image.FromFile(@"C:\Users\Użytkownik\Desktop\C#\zdj\pacjent.jpg");
        }
    }
}
