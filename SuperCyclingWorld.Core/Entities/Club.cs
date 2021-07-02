using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Club
    {
        public Guid Id { get; private set; }
        public string Clubnaam { get; private set; }
        public ICollection<ClubSupporter> ClubSupporters { get; private set; }

        public Club()
        {

        }

        public Club(string clubnaam)
        {
            Clubnaam = clubnaam;
        }
    }
}
