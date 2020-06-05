using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class Funkcio: RAMetaObjektum
    {

        [Ac4yMultiline]
        public string Szerep { get; set; }

        [Ac4yMultiline]
        public string Feltetel { get; set; }

        public string Utasitas { get; set; }

        public string Engedely { get; set; }

        public string Billentyu { get; set; }

        public string ErintettObjektum { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool KepernyoKapcsolat { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool OsMetodus { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool NemHasznalt { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool EgyediBeepites { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool FejlecElem { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool GombsorElem { get; set; }

    } // Funkcio

} // CSARMetaPlan.Class