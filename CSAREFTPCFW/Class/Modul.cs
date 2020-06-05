using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Modul : RAMetaObjektum
    {

        public List<Kepernyo> KepernyoLista { get; set; }


    }
}
