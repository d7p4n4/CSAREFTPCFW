using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class KepernyoAdatkor : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Képernyo adatkör.képernyo elem")]
        public List<KepernyoElem> KepernyoElemLista { get; set; }


        public List<KepernyoAdatkor> KepernyoAdatkorLista { get; set; }

        public string Kontener { get; set; }

        public Adatkor Adatkor { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("KepernyoAdatkor.Adatforras")]
        public Muvelet Forras { get; set; }

        public KepernyoAdatkor()
        {

            KepernyoElemLista = new List<KepernyoElem>();
            KepernyoAdatkorLista = new List<KepernyoAdatkor>();

        } // KepernyoAdatkor

    } // KepernyoAdatkor

} // CSARMetaPlan.Class