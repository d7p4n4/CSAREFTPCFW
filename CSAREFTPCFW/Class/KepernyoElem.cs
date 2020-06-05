using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class KepernyoElem : RAMetaObjektum
    {

        public string ElemTipus { get; set; }
        public string AdatForras { get; set; }
        public Adatkor ForrasKontener { get; set; }
        public string ForrasKontenerNeve { get; set; }
        public string InformaciosMezo { get; set; }
        public string IndexMezo { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("KepernyoElem.Adatforras")]
        public Muvelet Forras { get; set; }

    } // KepernyoElem

} // CSARMetaPlan.Class