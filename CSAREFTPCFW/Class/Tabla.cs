using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Tabla : RAMetaObjektum
    {

        public List<TablaOszlop> TablaOszlopLista { get; set; }

    }
}
