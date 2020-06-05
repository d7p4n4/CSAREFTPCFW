using Ac4y.Annotation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class Programkod : RAMetaObjektum
    {
        [Ac4yMultiline]
        public string Forrasszoveg { get; set; }

    } // Programkod

} // CSARMetaPlan.Class