using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSEFTPC4Core3Objects.Ac4yObjects
{
    public partial class Ac4yPersistent : Ac4y
    {
        //[Key]
        //public int persistentChildId { get; set; }

        public int Id { get; set; }
        public string GUID { get; set; }
        public string owner { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
