using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAREFTPCFW
{
    public class CAPs
    {
        public void InsertRAMetaObjektum(RAMetaObjektum raMetaObjektum)
        {

            using (var context = new Context())
            {
                
                context.RAMetaObjektums.Add(raMetaObjektum);
                context.SaveChanges();
            }

        } // Insert*/
    }
}

