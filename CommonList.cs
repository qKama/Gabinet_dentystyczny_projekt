using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace lista5
{
    public partial class CommonList : UserControl
    {
        private static CommonList _instance;
        private List<string> info2;

        public static CommonList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CommonList();
                return _instance;
            }
        }

        private void SerializeListToXML(List<string> list, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
            }
        }

        private List<string> DeserializeListFromXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            using (StreamReader reader = new StreamReader(filePath))
            {
                List<string> list = (List<string>)serializer.Deserialize(reader);
                return list;
            }
        }

        public CommonList()
        {
            InitializeComponent();
            btn_return.Visible =false;
            if(Form1.commonList.Count() <=0)
                btn_next.Visible = false;
        }

        int _index = 0;

        public void btn_prev_Click(object sender, EventArgs e)
        {
            btn_next.Visible = true;
            listBox1.Items.Clear();
            _index--;
            WriteInfo(Form1.commonList[_index]);
            if (_index == 0)
                btn_return.Visible = false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            btn_next.Visible = true;
            listBox1.Items.Clear();
            _index++;
            WriteInfo(Form1.commonList[_index]);
            if (_index == Form1.commonList.Count() - 1)
                btn_next.Visible = false;
                btn_return.Visible = true;
        }

        public void WriteInfo(Patient a)
        {
            info2 = a.GetInfo(); 
            foreach (var appointemntAdult in info2)
            {
                listBox1.Items.Add(appointemntAdult);
            }
            pictureBoxList.Image = a.Photo;
        }

        private void btn_child_Click(object sender, EventArgs e)
        {
            _index = 0;
            btn_next.Visible = false;
            btn_return.Visible = false;
            listBox1.Items.Clear();
            if (Form1.commonList.Count() != 0) 
            {
                if(Form1.commonList.Count() > 1)
                    btn_next.Visible=true;
                WriteInfo(Form1.commonList[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Użytkownik\\Desktop\\C#\\Projekt\\xml\\info2.xml"; 
            List<string> deserializedList = DeserializeListFromXML(filePath);
        }

        private void btn_serialization_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Użytkownik\\Desktop\\C#\\Projekt\\xml\\info2.xml";
            SerializeListToXML(info2, filePath);
        }
    }
}

