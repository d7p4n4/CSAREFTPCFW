using System;
using System.Collections.Generic;
using System.Text;

namespace CSEFTPC4Core3Objects.Ac4yObjects
{
    public partial class Ac4yIdentificationBase
    {
        public int Id { get; set; }
        public string GUID { get; set; }
        public string humanId { get; set; }
        public string publicHumanId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
