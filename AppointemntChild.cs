using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lista5
{
    class AppointemntChild : Patient
    {
        private string _ParentsName;
        private string _ParentsLastName;
        private string _ParentsPhonNo;
        private string _refunded;
        private string _braces;
        public string _point;
        public int _countingpoints;
        int _zloty;

        public AppointemntChild() : base()
        {
            _ParentsName = "Anna";
            _ParentsLastName = "Kowalska";
            _ParentsPhonNo = "523654858";
            _refunded = "tak";
            _braces = "Górny łuk";
            _point = "20";
        }

        public AppointemntChild(string ParentsName, string ParentsLastName, string ParentsPhonNo, string name, string lastname, DateTime rokUr, string city, string street, string noHouse, string pesel, DateTime data, string godzinaWizyty, string refunded, Bitmap photo, string braces, List<string> teeth, string point) : base(name, lastname, rokUr, city, street, noHouse, pesel, data, godzinaWizyty,photo, teeth)
        {
            _ParentsName = ParentsName;
            _ParentsLastName = ParentsLastName;
            _ParentsPhonNo = ParentsPhonNo;
            _refunded = refunded;
            _braces = braces;
            _point = point;
        }

        public AppointemntChild(AppointemntChild c) : base(c)
        {
            _ParentsName = c._ParentsName;
            _ParentsLastName = c._ParentsLastName;
            _ParentsPhonNo = c._ParentsPhonNo;
            _refunded = c._refunded;
            _braces = c._braces;
            _point = c._point;
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
                return  20;
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
            _zloty = _countingpoints * 3;

            return _zloty;
        }

        public string Braces()
        {
            if( _braces == "nie")
            {
                return " Nie ma porzeby zakłądania aparatu ortodontycznego";
            }

            return _braces;
        }

        public override List<string> GetInfo()
        {
            List<string> info2 = base.GetInfo();
            info2.Add("Imie, nazwisko rodzica/opikuna parawnego:\t" + _ParentsName + " " + _ParentsLastName);
            info2.Add("Nr. Tel. rodzica/opikuna parawnego:\t" + _ParentsPhonNo);
            info2.Add("");
            info2.Add("Aparat ortodontyczny: \t" + Braces());
            info2.Add("Zabieg: \t" + _point);
            info2.Add("Refundowane: \t" + Refunded());
            if (_refunded != "Nie")
            {
                info2.Add("Ilosć punktów za zabieg: \t" + Points());
                if (Points() > 30)
                {
                    _countingpoints = _countingpoints + 10;
                    info2.Add("Przysługują dodatkowe punkty");
                    info2.Add("suma punktów wynosi: \t" + _countingpoints);
                }
                info2.Add("Pieniądze zdobyte za punkty: \t" + CountingMoney());
            }
            else
            {
                info2.Add("Opłata za zabieg: \t" + Points() + " PLN");

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
