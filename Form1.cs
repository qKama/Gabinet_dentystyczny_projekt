using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lista5
{
    public partial class Form1 : Form
    {
        public static List<Patient> commonList = new List<Patient>();
        public Form1()
        {
            InitializeComponent();
        }

        public void form1_load(object sender, EventArgs e)
        {

        }

        private void btn_apAd_Click(object sender, EventArgs e)
        {
            Height = 727;
            Width = 1100;
            if (!panel2.Controls.Contains(PatientAdult.Instance))
            {
                panel2.Controls.Add(PatientAdult.Instance);
                PatientAdult.Instance.Dock = DockStyle.Fill;
                PatientAdult.Instance.BringToFront();
            }
            else
                PatientAdult.Instance.BringToFront();
        }

        private void btn_apCh_Click(object sender, EventArgs e)
        {
            Height = 727;
            Width = 1100;
            if (!panel2.Controls.Contains(PatientChild.Instance))
            {
                panel2.Controls.Add(PatientChild.Instance);
                PatientChild.Instance.Dock = DockStyle.Fill;
                PatientChild.Instance.BringToFront();
            }
            else
                PatientChild.Instance.BringToFront();
        }

        private void btn_CommonList_Click(object sender, EventArgs e)
        {
            Height = 671;
            Width = 716;
            if (!panel2.Controls.Contains(CommonList.Instance))
            {
                panel2.Controls.Add(CommonList.Instance);
                CommonList.Instance.Dock = DockStyle.Fill;
                CommonList.Instance.BringToFront();
            }
            else
                CommonList.Instance.BringToFront();
        }

        private void NFZ_Click(object sender, EventArgs e)
        {

        }
    }
}

