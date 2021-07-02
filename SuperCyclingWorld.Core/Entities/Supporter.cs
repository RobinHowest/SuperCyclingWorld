using SuperCyclingWorld.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Supporter : Persoon
    {
        public ICollection<ClubSupporter> Clubs { get; set; }

        public Supporter()
        {

        }

        public Supporter(string voornaam, string achternaam) : base(voornaam, achternaam)
        {

        }
    }
}
