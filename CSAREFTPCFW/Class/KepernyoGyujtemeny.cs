using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class KepernyoGyujtemeny : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("KepernyoGyujtemeny.Kepernyo")]
        public List<Kepernyo> KepernyoLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("KepernyoGyujtemeny.KepernyoFejlesztesiAllapot")]
        public List<KepernyoFejlesztesiAllapot> KepernyoFejlesztesiAllapotLista { get; set; }

    } // KepernyoGyujtemeny

} // CSARMetaPlan.Class