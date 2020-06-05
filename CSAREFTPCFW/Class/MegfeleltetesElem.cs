using Ac4y.Annotation;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public partial class MegfeleltetesElem : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesElem.Forras")]
        [NotMapped]
        public RAMetaObjektum Forras { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("MegfeleltetesElem.Cel")]
        [NotMapped]
        public RAMetaObjektum Cel { get; set; }
        
    } // MegfeleltetesElem

} // CSARMetaPlan.Class