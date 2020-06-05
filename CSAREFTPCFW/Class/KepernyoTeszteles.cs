using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{

    [NeedToSerialize]
    [Persistent]

    public class KepernyoTeszteles : Teszteles
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Teszteles.Kepernyo")]

        public Kepernyo Kepernyo { get; set; }

    } // KepernyoTeszteles

} // CSARMetaPlan.Class