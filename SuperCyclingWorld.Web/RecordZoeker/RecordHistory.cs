using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.RecordZoeker
{
    public class RecordHistory
    {
        public Guid Id { get; set; }
        public Guid RecordId { get; set; }
        public Record Record { get; set; }
        public DateTime Timestamp { get; set; }

        public RecordHistory()
        {

        }

        public RecordHistory(Record record)
        {
            Record = record;
            RecordId = record.Id;
            Id = Guid.NewGuid();
            Timestamp = DateTime.Now;

        }
    }
}
