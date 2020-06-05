using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{

    [NeedToSerialize]
    [Persistent]

    public class Metodus : RAMetaObjektum
    {

        public int Uzemmod { get; set; }
        public bool Skalar { get; set; }
        public List<TaroltEljarasArgumentum> ArgumentumLista { get; set; }

        [Ac4yMultiline]
        public string Szerep { get; set; }

    } // Metodus

} // CSARMetaPlan.Class