using SuperCyclingWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Record
    {
        public Guid Id { get; private set; }
        public Wielrenner Wielrenner { get; private set; }
        public Recordtype RecordType { get; private set; }
        public string Recordnaam { get; set; }
        public int RecordCijfer { get; set; }
        public string RecordEenheid { get; set; }
        public string Thropy { get; set; }

        public ICollection<WielrennerRecords> WielrennerRecords { get; set; }

        public Record()
        {
        }

        public Record(Wielrenner wielrenner, Recordtype recordtype, string recordnaam, int recordcijfer, string recordeenheid)
        {
            Id = Guid.NewGuid();
            Wielrenner = wielrenner;
            RecordType = recordtype;
            Recordnaam = recordnaam;
            RecordCijfer = recordcijfer;
            RecordEenheid = recordeenheid;
            SetTrophy();
        }

        private void SetTrophy()
        {
            if(RecordType == Recordtype.Site)
            {
                Thropy = "/images/functionalImages/SiteRecordThropy.png";
            }
            if (RecordType == Recordtype.Club)
            {
                Thropy = "/images/functionalImages/ClubRecordThropy.png";
            }
            if (RecordType == Recordtype.Wielrenner)
            {
                Thropy = "/images/functionalImages/PersonalRecordThropy.png";
            }
        }
    }
}
