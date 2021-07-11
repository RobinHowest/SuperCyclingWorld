using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class WielrennerRecords
    {
        public Wielrenner Wielrenner { get; set; }
        public Guid WielrennerId { get; set; }
        public Record Record { get; set; }
        public Guid RecordId { get; set; }
    }
}
