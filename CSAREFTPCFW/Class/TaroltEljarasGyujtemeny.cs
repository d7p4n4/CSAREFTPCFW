using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class TaroltEljarasGyujtemeny : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("TaroltEljarasGyujtemeny.TaroltEljaras")]
        public List<TaroltEljaras> TaroltEljarasLista { get; set; }

    } // TaroltEljarasGyujtemeny

} // CSARMetaPlan.Class