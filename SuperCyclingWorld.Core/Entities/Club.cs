using SuperCyclingWorld.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Club
    {
        public Guid Id { get; private set; }
        public string Clubnaam { get; private set; }
        public Guid? Clubleider { get; private set; }
        public ICollection<Wielrenner> Leden { get; private set; }
        public ICollection<ClubSupporter> ClubSupporters { get; private set; }

        public Club()
        {

        }

        public Club(string clubnaam, Persoon persoon)
        {
            Clubnaam = clubnaam;
            Clubleider = persoon.Id;
        }
    }
}
