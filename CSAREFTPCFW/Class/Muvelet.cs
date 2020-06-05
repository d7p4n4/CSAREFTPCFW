using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{

    [NeedToSerialize]
    [Persistent]

    public partial class Muvelet : RAMetaObjektum
    {
        /*
        public enum ValaszTipusFelsorolas
        {
            ELEMI = 1,
            OBJEKTUM = 2,
            LISTA = 3
        }

        public ValaszTipusFelsorolas ValaszTipus { get; set; }
*/
        public int ValaszTipus { get; set; }

        public int TurelmiIdo { get; set; }
     
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Nevproblemas { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Foazonositos { get; set; }
        /*
        [Ac4yEmbedded]
        [Ac4yAssociationPath("Muvelet.Keres")]
        public Adatkor Keres { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Muvelet.Valasz")]
        public Adatkor Valasz { get; set; }
        */
        [Ac4yEmbedded]
        [Ac4yAssociationPath("Muvelet.Argumentum")]
        public List<TaroltEljarasArgumentum> ArgumentumLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("Muvelet.Megfeleltetes")]
        public List<Muvelet> MegfeleltetesLista { get; set; }
        
        [Ac4yEmbedded]
        [Ac4yAssociationPath("Muvelet.MegfeleltetesCsomopont")]
        public List<MegfeleltetesCsomopont> MegfeleltetesCsomopontLista { get; set; }

        public string FoAzonosito { get; set; }

    } // Muvelet

} // CSARMetaPlan.Class