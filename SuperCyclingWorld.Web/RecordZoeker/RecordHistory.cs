using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Enums;
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
        public Guid WielrennerId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Recordnaam { get; set; }
        public int RecordCijfer { get; set; }
        public string RecordEenheid { get; set; }
        public Recordtype? RecordType { get; set; }
        public RecordHistory()
        {

        }

        public RecordHistory(Record record)
        {
            Id = Guid.NewGuid();
            Timestamp = DateTime.Now;
            RecordId = record.Id;
            WielrennerId = record.Wielrenner.Id;
            Recordnaam = record.Recordnaam;
            RecordCijfer = record.RecordCijfer;
            RecordEenheid = record.RecordEenheid;
            RecordType = record.RecordType;
        }
    }
}
