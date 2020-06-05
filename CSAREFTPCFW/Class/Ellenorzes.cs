using Ac4y.Annotation;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Ellenorzes: RAMetaObjektum
    {

        public string Uzenet { get; set; }

        [Ac4yMultiline]
        public string Feltetel { get; set; }

    } // Ellenorzes

} // CSARMetaPlan.Class