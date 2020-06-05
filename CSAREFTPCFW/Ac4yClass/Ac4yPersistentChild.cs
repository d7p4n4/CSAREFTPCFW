using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSEFTPC4Core3Objects.Ac4yObjects
{
    public class Ac4yPersistentChild : Ac4yPersistent
    {
        public string name { get; set; }
        public int ages { get; set; }
    }
}
