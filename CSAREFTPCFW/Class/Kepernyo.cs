using Ac4y.Annotation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]
    public class Kepernyo : RAMetaObjektum
    {
        
        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("Kepernyo.Kepernyo")]
        public List<Kepernyo> KepernyoLista { get; set; }
        
        [Ac4yEmbedded]
        //[Ac4yWithoutChild]
        [Ac4yAssociationPath("Kepernyo.Adatkor")]
        public List<KepernyoAdatkor> KepernyoAdatkorLista { get; set; }
        
        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("Kepernyo.TaroltEljaras")]
        public List<TaroltEljaras> TaroltEljarasLista { get; set; }
        
        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("Kepernyo.Muvelet")]
        public List<Muvelet> MuveletLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Kepernyo.Funkcio")]
        public List<Funkcio> FunkcioLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Kepernyo.Ellenorzes")]
        public List<Ellenorzes> EllenorzesLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Kepernyo.Metodus")]
        public List<Metodus> MetodusLista { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Kepernyo.Feladat")]
        public List<Feladat> FeladatLista { get; set; }
        
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public string RegiKepernyo { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public string UjKepernyo { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public string GyermekListaKepernyo { get; set; }
        /*
        [Ac4yEmbedded]
        [Ac4yWithoutChild]
        [Ac4yAssociationPath("Képernyő.fő adatforrás művelet")]
        [NotMapped]
        public Muvelet FoAdatforras { get; set; }*/

        [Ac4yAssociationPath("Kepernyo.FoAzonosito")]
        public string FoAzonosito { get; set; }
        
    } // Kepernyo

} // CSARMetaPlan.Class