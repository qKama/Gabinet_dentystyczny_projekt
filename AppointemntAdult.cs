using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lista5
{
    class AppointemntAdult : Patient
    {

        private string _phonNo;
        private string _scPersonName;
        private string _scPersonLastName;
        private string _scPersonPesel;
        private string _refunded;
        public string _point;
        public int _countingpoints;
        public int _zloty = 2;

        public AppointemntAdult() : base()
        {
            _phonNo = "655489966";
            _refunded = "tak";
            _scPersonName = "Emilia";
            _scPersonLastName = "Kowalczyk";
            _scPersonPesel = "455121355869";
            _point = "20";
        }

        public AppointemntAdult(string scPersonName, string scPersonLastName, string scPersonPesel, string PhonNo, string name, string lastname, DateTime rokUr, string city, string street, string noHouse, string pesel, DateTime data, string godzinaWizyty, string refunded, Bitmap photo, List<string> teeth, string point) : base(name, lastname, rokUr, city, street, noHouse, pesel, data, godzinaWizyty, photo, teeth)
        {
            _phonNo = PhonNo;
            _scPersonName = scPersonName;
            _scPersonLastName = scPersonLastName;
            _scPersonPesel = scPersonPesel;
            _refunded = refunded;
            _point = point;
        }

        public AppointemntAdult(AppointemntAdult a) : base(a)
        {
            _phonNo = a._phonNo;
            _scPersonName = a._scPersonName;
            _scPersonLastName = a._scPersonLastName;
            _scPersonPesel = a._scPersonPesel;
            _refunded = a._refunded;
            _point =a._point;
        }

        public string Refunded()
        {
            if (_refunded != "Nie")
            {
                return "Leczenie jest refundowane";
            }
            else
            {
                return "Leczenie nie jest refundowane";
            }
        }

        public int Points()
        {

            if (_point == "Lakierowanie")
            {
                _countingpoints = 20;
                
                return 20;
            }
            else if (_point == "Piaskowanie")
            {
                _countingpoints = 27;
             
                return 27;
            }
            else if (_point == "Czyszczenie Kieszonek")
            {
                _countingpoints = 50;
                
                return 50;
            }
            else if (_point == "Wyrywanie Zęba (z znieczuleniem i opatrunkiem)")
            {
                _countingpoints = 80;
                
                return 80;
            }

            return 0;
        }

        public int CountingMoney()
        {
            _zloty = _countingpoints * 2;

            return _zloty;
        }

        public string PhonNo()
        {
            if (_phonNo == "")
            {
                MessageBox.Show("Prosimy podać nr. Telefonu", "Uwaga!");
                return "Prosimy uzupełnić pole";
            }
            return _phonNo;     
        }

        public override List<string> GetInfo()
        {
            List<string> info2 = base.GetInfo();
            info2.Add("Nr. Tel.:\t" + PhonNo());
            info2.Add("");
            info2.Add("Osoba upoważniona do informacji medycznych pacjenta:\t");
            info2.Add("Imie i Nazwisko: \t" + _scPersonName + " " + _scPersonLastName);
            info2.Add("PESEL: \t" + _scPersonPesel);
            info2.Add("");
            info2.Add("Zabieg: \t" + _point);
            info2.Add("Refundowane: \t" + Refunded());
            if (_refunded != "Nie")
            {
                info2.Add("Ilosć punktów za zabieg: \t" + Points());
                if(Points()>30)
                {
                    _countingpoints = _countingpoints + 10;
                    info2.Add("Przysługują dodatkowe punkty");
                    info2.Add("suma punktów wynosi: \t" + _countingpoints);
                }
                info2.Add("Pieniądze zdobyte za punkty: \t" + CountingMoney()); 
            }
            else
            {
            info2.Add("Opłata za zabieg: \t" + CountingMoney() + " PLN");
            }
            info2.Add("");

            return info2;
        }

        public override void WritePhotoToFile(string fullFileName)
        {
            _photo.Save(fullFileName, ImageFormat.Bmp);
        }

        public override void ReadPhotoFromFile(string fullFileName)
        {
            _photo = (Bitmap)Image.FromFile(fullFileName);
        }

    }
}
