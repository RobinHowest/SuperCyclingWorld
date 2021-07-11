using Microsoft.EntityFrameworkCore;
using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.RecordZoeker
{
    public class RecordsZoeker
    {

        private readonly SCWDbContext _dbContext;


        public RecordsZoeker(SCWDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        private void GetWielrenner_Highest_KM_Site()
        {

            int maxKMSiteNiveau = _dbContext.Wielrenners.Max(w => w.TotaalAantalGeredenKilometers);
            Wielrenner wielrennerSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMSiteNiveau).Include(c => c.Club).SingleOrDefault();
            RecordList.Records.Add(new Record(wielrennerSelected, Recordtype.Site, "Record hoogste KM", maxKMSiteNiveau, "Kilometer"));


        }

        private void GetWielrenner_Highest_KM_Club()
        {

            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                int maxKMClubNiveau = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.TotaalAantalGeredenKilometers);
                Wielrenner wielrennerSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMClubNiveau && w.ClubId == club.Id).SingleOrDefault();
                RecordList.Records.Add(new Record(wielrennerSelected, Recordtype.Club, "Record hoogste KM ", maxKMClubNiveau, "Kilometer"));
            }


        }
        public void FillInRecords()
        {
            GetWielrenner_Highest_KM_Site();
            GetWielrenner_Highest_KM_Club();

            foreach (Record record in RecordList.Records)
            {
                if (record.RecordType == Recordtype.Site)
                {
                    record.Wielrenner.Club.AantalRecords++;
                }
            }

        }
    }
}
