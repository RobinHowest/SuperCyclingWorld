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
        public void FillInRecords(ICollection<Club> clubs)
        {
            if (SearchedForSiteRecords == false)
            {
                //Records
                GetWielrenner_HighestTotal_KM_Site();
                GetWielrenner_HighestTotal_KM_Club();
                GetWielrenner_Highest_Gemiddelde_KM_h_Site();
                GetWielrenner_Highest_Gemiddelde_KM_h_Club();
                GetWielrenner_Highest_Gemiddelde_KM_rit_Site();
                GetWielrenner_Highest_Gemiddelde_KM_rit_Club();
                GetWielrenner_Highest_wattage_site();
                GetWielrenner_Highest_wattage_Club();
                //Records


                GiveClubsThereAantalRecords(clubs);// kan pas gebeuren als alle records zijn toegevoegd aan de recordlist !!

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
        //RECORD ------------- Meeste Kilometers (club en siteniveau)
        private void GetWielrenner_HighestTotal_KM_Site()
        {

            int maxKMSiteNiveau = _dbContext.Wielrenners.Max(w => w.TotaalAantalGeredenKilometers);
            List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMSiteNiveau).Include(c => c.Club).ToList();
            foreach (Wielrenner wielrenner in wielrennersSelected)
            {
                RecordList.Records.Add(new Record(wielrenner, Recordtype.Site, "Kilometervreter (Siteniveau)", maxKMSiteNiveau, "Kilometer"));
            }


        }

        private void GetWielrenner_HighestTotal_KM_Club()
        {

            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                int maxKMClubNiveau = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.TotaalAantalGeredenKilometers);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.TotaalAantalGeredenKilometers == maxKMClubNiveau && w.ClubId == club.Id).ToList();
                foreach (Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Club, "Kilometervreter (Clubniveau)", maxKMClubNiveau, "Kilometer"));
                }
            }


        }
        // EINDE RECORD

        //RECORD ------------- Meeste Kilometers/uur (club en siteniveau)
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
        // EINDE RECORD

        //RECORD ------------- Meeste Kilometers/rit (club en siteniveau)
        private void GetWielrenner_Highest_Gemiddelde_KM_rit_Site()
        {

            int maxGemiddeld_KM_h = _dbContext.Wielrenners.Max(w => w.GemiddeldeKM_Rit);
            List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.GemiddeldeKM_Rit == maxGemiddeld_KM_h).ToList();

            foreach (Wielrenner wielrenner in wielrennersSelected)
            {
                RecordList.Records.Add(new Record(wielrenner, Recordtype.Site, "Hoogste Gemiddelde KM/Rit (Siteniveau)", (int)maxGemiddeld_KM_h, "Kilometer"));
            }


        }

        private void GetWielrenner_Highest_Gemiddelde_KM_rit_Club()
        {

            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                double maxGemiddeld_KM_h = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.GemiddeldeKM_Rit);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.GemiddeldeKM_Rit == maxGemiddeld_KM_h && w.ClubId == club.Id).ToList();

                foreach (Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Club, "Hoogste Gemiddelde KM/Rit (Clubniveau)", (int)maxGemiddeld_KM_h, "Kilometer"));
                }
            }


        }
        // EINDE RECORD

        //RECORD ------------- Meeste Wattage getrapt (club en siteniveau)
        private void GetWielrenner_Highest_wattage_site()
        {
                int wattageRecord = _dbContext.Wielrenners.Max(w => w.WattageRecord);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.WattageRecord == wattageRecord).ToList();

                foreach(Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Site, "Hoogste wattage (Siteniveau)", wattageRecord, "Watt"));
                }
        }
        private void GetWielrenner_Highest_wattage_Club()
        {
            foreach (Club club in _dbContext.Clubs.OrderBy(c => c.Id).ToList())
            {
                int wattageRecord = _dbContext.Wielrenners.Where(w => w.ClubId == club.Id).Max(w => w.WattageRecord);
                List<Wielrenner> wielrennersSelected = _dbContext.Wielrenners.Where(w => w.WattageRecord == wattageRecord && w.ClubId == club.Id).ToList();

                foreach (Wielrenner wielrenner in wielrennersSelected)
                {
                    RecordList.Records.Add(new Record(wielrenner, Recordtype.Club, "Hoogste wattage (Clubniveau)", wattageRecord, "Watt"));
                }
            }
        }
        // EINDE RECORD





        //Update de records wat betreft het aantal siterecords die clubs op dit moment bezitten.
        private void GiveClubsThereAantalRecords(ICollection<Club> clubs)
        {
            foreach (var club in clubs)
            {
                club.AantalRecords = RecordList.Records.Where(r => r.Wielrenner.Club.Id == club.Id && r.RecordType == Recordtype.Site).Count();
            }
        }

    }
}
