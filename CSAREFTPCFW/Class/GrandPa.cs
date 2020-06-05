using Ac4y.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAKEFTPC4Core3.Class
{
    public class GrandPa
    {
        [NeedToSerialize]
        [Persistent]

        public class RAMetaObjektum
        {

            //[Ac4yReadOnly]
            public string GUID { get; set; }

            //[Ac4yReadOnly]
            public string Nev { get; set; }

            [Ac4yReadOnly]
            public string Megnevezes { get; set; }

            //[Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
            //[Ac4yReadOnly]
            public string Kod { get; set; }

            [Ac4yReadOnly]
            public string PublikusKod { get; set; }

            [Ac4yReadOnly]
            public string Nevter { get; set; }

            [Ac4yMultiline]
            public string Leiras { get; set; }

            [Ac4yReadOnly]
            public int Id { get; set; }

            [Ac4yReadOnly]
            [Ac4yMultiline]
            public string Serialization { get; set; }

        }
    }
}