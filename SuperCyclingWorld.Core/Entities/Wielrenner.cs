using SuperCyclingWorld.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Wielrenner : Persoon
    {
        public Guid ClubId { get; private set; }
        public Club Club { get; private set; }
        public ICollection<Fiets> Fietsen { get; private set; }

        public Wielrenner()
        {

        }

        public Wielrenner(string voornaam, string achternaam, string paswoord, string email, DateTime geboorteDatum) : base (voornaam, achternaam, paswoord, email, geboorteDatum)
        {

        }
        public Wielrenner(Guid clubId, string voornaam, string achternaam, string paswoord, string email, DateTime geboorteDatum) : base(voornaam, achternaam, paswoord, email, geboorteDatum)
        {
            ClubId = clubId;
        }
    }
}
