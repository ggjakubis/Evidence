using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub_Maly_I2B2
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int ID { get; set; }
        public int Narozeni { get; set; }
        public Zamestnanec(string jmeno, string prijmeni, int id, int narozeni) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            ID = id;
            Narozeni = id;
        }
        public override string ToString()
        {
            return $"{ID}\t{Jmeno}\t{Prijmeni}\t{Narozeni}";
        }


    }
}
