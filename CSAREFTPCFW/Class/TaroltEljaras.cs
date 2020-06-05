using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class TaroltEljaras : RAMetaObjektum
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("TaroltEljaras.Muvelet")]

        public List<Muvelet> MuveletLista { get; set; }

        public List<Metodus> MetodusLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("TaroltEljaras.Argumentum")]

        public List<TaroltEljarasArgumentum> ArgumentumLista { get; set; }

        public string MuveletArgumentum { get; set; }

    }
}
