using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprava_Test
{
    public class Zamestnanec
    {
        public Zamestnanec(string jmeno, string prijmeni, int id, DateOnly datumnarozeni)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }


        public int? Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateOnly DatumNarozeni { get; set; }
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {DatumNarozeni.ToShortDateString()}";
        }
    }
}
