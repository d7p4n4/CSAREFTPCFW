using Ac4y.Annotation;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class TaroltEljarasArgumentum : RAMetaObjektum
    {
        public string Adattipus { get; set; }
        public string HumanNev { get; set; }
        public string BelsoNev { get; set; }
        public string Irany { get; set; }
        public bool Opcionalis { get; set; }
    }
}
