using System;
using System.Collections.Generic;

namespace Tripforo.Repository.EFCoreModels.ScaffoldedEntity
{
    public partial class TblSoapaction
    {
        public int Counter { get; set; }
        public string? Soapactionurl { get; set; }
        public string? Soapactionmethod { get; set; }
        public string? Provider { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
