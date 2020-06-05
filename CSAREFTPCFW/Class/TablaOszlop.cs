using Ac4y.Annotation;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class TablaOszlop : RAMetaObjektum
    {
        public string Adattipus { get; set; }
    }
}
