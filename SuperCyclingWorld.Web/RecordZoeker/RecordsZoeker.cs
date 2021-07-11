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
        private static bool SearchedForSiteRecords = false;

        public RecordsZoeker(SCWDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public void FillInRecords()
        {
            if (SearchedForSiteRecords == false)
            {
                GetWielrenner_Highest_KM_Site();
                GetWielrenner_Highest_KM_Club();
                GetWielrenner_Highest_Gemiddelde_KM_h_Site();
                GetWielrenner_Highest_Gemiddelde_KM_h_Club();

                foreach (Record record in RecordList.Records)
                {
                    if (record.RecordType == Recordtype.Site)
                    {
                        record.Wielrenner.Club.AantalRecords++;
                    }

                    if (record.RecordType == Recordtype.Club)
                    {
                        record.Wielrenner.AantalRecords++;
                    }

                }
                SearchedForSiteRecords = true;
            }
        }

        private void GetWielrenner_Highest_KM_Site()
        {

            int maxKMSiteNiveau = _dbContext.Wielrenners.Max(w => w.TotaalAantalGeredenKilometers);
            List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMSiteNiveau).Include(c => c.Club).ToList();
            foreach (Wielrenner wielrenner in wielrennersSelected)
            {
                RecordList.Records.Add(new Record(wielrenner, Recordtype.Site, "Kilometervreter (Siteniveau)", maxKMSiteNiveau, "KM/Uur"));
            }


        }

        private void GetWielrenner_Highest_KM_Club()
        {

            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                int maxKMClubNiveau = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.TotaalAantalGeredenKilometers);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMClubNiveau && w.ClubId == club.Id).ToList();
                foreach (Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Club, "Kilometervreter (Clubniveau)", maxKMClubNiveau, "KM/Uur"));
                }
            }


        }

        private void GetWielrenner_Highest_Gemiddelde_KM_h_Site()
        {

            double maxGemiddeld_KM_h = _dbContext.Wielrenners.Max(w => w.GemiddeldKm_h);
            List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.GemiddeldKm_h == maxGemiddeld_KM_h).ToList();

            foreach(Wielrenner wielrenner in wielrennersSelected)
            {
                RecordList.Records.Add(new Record(wielrenner, Recordtype.Site, "Snelheidsduivel (Siteniveau)", (int)maxGemiddeld_KM_h, "KM/Uur"));
            }


        }

        private void GetWielrenner_Highest_Gemiddelde_KM_h_Club()
        {

            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                double maxGemiddeld_KM_h = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.GemiddeldKm_h);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.GemiddeldKm_h == maxGemiddeld_KM_h && w.ClubId == club.Id).ToList();

                foreach (Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Club, "Snelheidsduivel (Clubniveau)", (int)maxGemiddeld_KM_h, "KM/Uur"));
                }
            }


        }

    }
}
