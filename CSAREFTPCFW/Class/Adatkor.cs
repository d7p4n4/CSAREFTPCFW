using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Adatkor: RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Adatkor.Elem")]

        public List<AdatElem> AdatElemLista { get; set; }

    }
}
