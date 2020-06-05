using Ac4y.Annotation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public partial class MegfeleltetesCsomopont : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("MegfeleltetesCsomopont.MegfeleltetesElem")]
        public List<MegfeleltetesElem> MegfeleltetesElemLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesCsomopont.Forras")]
        [NotMapped]
        public Muvelet ForrasMuvelet { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesCsomopont.Cel")]
        public Muvelet CelMuvelet { get; set; }

    } // MegfeleltetesCsomopont

} // CSARMetaPlan.Class