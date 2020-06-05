using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAREFTPCFW
{
    class Program
    {
        static void Main(string[] args)
        {
            new CAPs().InsertRAMetaObjektum(new Programkod()
            {
                Forrasszoveg = "teszt szöveg"
                , Id = 1
            });
        }
    }
}
