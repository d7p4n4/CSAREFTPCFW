using Ac4y.Annotation;
using System.Collections.Generic;

namespace CSARMetaPlan.Class
{
    [NeedToSerialize]
    [Persistent]

    public class MediaObjektum : RAMetaObjektum
    {

        [Ac4yMultiline]
        public string Forras { get; set; }

    } // MediaObjektum

} // CSARMetaPlan.Class