using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub_Maly_I2B2
{
    public class Evidence
    {
        public List<Zamestnanec> zamestnanci;
        public Evidence()
        {
            zamestnanci = new();
        }
        public List<Zamestnanec> Zamestnanci => zamestnanci;
        public int getID()
        {
            return zamestnanci.Count == 0 ? 1 : zamestnanci.OrderBy(x => x.ID).Last().ID + 1;
        }


    }
}
