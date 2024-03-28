using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace lista5
{
    public abstract class Patient
    {
        private static int _noOfPeople = 0;
        

        protected int _id;
        protected string _name;
        protected string _lastname;
        protected DateTime _birthYear;
        protected string _city;
        protected string _street;
        protected string _houseNo;
        private string _pesel;
        protected DateTime _appointmentDate;
        protected string _appointmentHour;
        protected List<string> _teeth = new List<string>();
        protected Bitmap _photo;

        public Bitmap Photo
        {
            get => _photo;
        }

        public Patient()
        {
            _noOfPeople += 1;
            _id = _noOfPeople;
            _name = "Bartek";
            _lastname = "Cisek";
            _birthYear = DateTime.Now;
            _pesel = "0325216345";
            _city = "Opole";
            _street = "Ozimska";
            _houseNo = "48";
            _appointmentDate = DateTime.Now;
            _appointmentHour = "14:00";
        }

        public Patient(string name, string lastname, DateTime rokUr, string city, string street, string noHouse, string pesel, DateTime dataWizyty, string godzinaWizyty, Bitmap photo, List<string> teeth)
        {
            _noOfPeople += 1;
            _id = _noOfPeople;
            _name = name;
            _lastname = lastname;
            _birthYear = rokUr;
            _pesel = pesel;
            _city = city;
            _street = street;
            _houseNo = noHouse;
            _appointmentDate = dataWizyty;
            _appointmentHour = godzinaWizyty;
            _teeth = teeth;
            _photo = photo;
        }

        public Patient(Patient o)
        {
            _noOfPeople += 1;
            _id = _noOfPeople;
            _name = o._name;
            _lastname = o._lastname;
            _birthYear = o._birthYear;
            _pesel = o._pesel;
            _city = o._city;
            _street = o._street;
            _houseNo = o._houseNo;
            _appointmentDate = o._appointmentDate;
            _appointmentHour = o._appointmentHour;
        }

        public static bool operator ==(Patient patient1, Patient patient2)
        {
            if (patient1._pesel == patient2._pesel)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Patient patient1, Patient patient2)
        {
            if (patient1._pesel != patient2._pesel)
            {
                return false;
            }
            return true;
        }


        public virtual List<string> GetInfo()
        {
            List<string> info = new List<string>();
            info.Add("id:\t\t" + _id);
            info.Add("Imię i nazwisko:\t" + _name + " " + _lastname);
            info.Add("Rok urodzenia:\t" + _birthYear);
            info.Add("Wiek:\t\t" + CalculateAge()); 
            info.Add("PESEL: \t\t" + _pesel);
            info.Add("Adres:\t\t" + _city + " ul." + _street + " " + _houseNo);
            info.Add("");
            info.Add("Data wizyty:\t" + _appointmentDate);
            info.Add("Godzina: \t\t" + _appointmentHour);
            info.Add("Zęby do leczenia: \t\t" );
            foreach (var item in _teeth)
            {
                info.Add(item.ToString());
            }
            return info;
        }

        protected int CalculateAge()
        {

            return DateTime.Now.Year - _birthYear.Year;
             
        }

        public void AddTeeth(string tooth)
        {
            _teeth.Add(tooth);
        }

        public void ShowPicture()
        {
            Bitmap _photo = Photo;
        }

        public virtual void WritePhotoToFile(string fullFileName)
        {
        }

        public virtual void ReadPhotoFromFile(string fullFileName)
        {
        }
    }
}
