using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Feladat : RAMetaObjektum
    {

        public string Tipus { get; set; }
        public string Azonosito { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool MegvalositasFolyamatban { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool MegvalositasKesz { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool JavitasFolyamatban { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool JavitasKesz { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool EllenorzesFolyamatban { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Hibatlan { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Hibas { get; set; }

        public int KeszultsegiSzazalek { get; set; }

        public string Megvalosito { get; set; }
        public string Ellenorzo { get; set; }

        [Ac4yEmbedded]
        [Ac4yAssociationPath("Feladat.Feladat")]
        public List<Feladat> FeladatLista { get; set; }

    }

} // CSARMetaPlan.Class