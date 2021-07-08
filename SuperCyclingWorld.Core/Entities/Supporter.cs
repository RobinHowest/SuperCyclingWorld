using SuperCyclingWorld.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Supporter : Persoon
    {
        public ICollection<ClubSupporter> Clubs { get; private set; }

        public Supporter()
        {

        }

        public Supporter(string voornaam, string achternaam, string paswoord, string email, DateTime geboortedatum) : base(voornaam, achternaam, paswoord, email, geboortedatum)
        {

        }
    }
}
