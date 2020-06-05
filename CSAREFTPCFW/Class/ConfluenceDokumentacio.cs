using Ac4y.Annotation;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class ConfluenceDokumentacio : RAMetaObjektum
    {

        [Ac4yMultiline]
        public string Tartalom { get; set; }

        public int OldalAzonosito { get; set; }

    } // ConfluenceDokumentacio

} // CSARMetaPlan.Class