using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{

    [NeedToSerialize]
    [Persistent]

    public class KepernyoFejlesztesiAllapot : FejlesztesiAllapot
    {

        [Ac4yEmbedded]
        [Ac4yAssociationPath("FejlesztesiAllapot.Kepernyo")]

        public Kepernyo Kepernyo { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool ZsombiDoksi { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool ZsombiDoksiEllenorizve { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Screenshot { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool Elrendezes { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool BetoltesFunkcioKigyujtve{ get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool ElrendezesBehelyettesitve { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool TeljesNyersKepernyoOsszerakva { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool KezeloOsztalyKesz { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool MappingKesz { get; set; }

        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool MappingJo { get; set; }
    } // KepernyoFejlesztesiAllapot

} // CSARMetaPlan.Class