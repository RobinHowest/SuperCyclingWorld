using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Club
    {
        public Guid Id { get; set; }
        public string Clubnaam { get; set; }

        public Club()
        {

        }

        public Club(string clubnaam)
        {
            Clubnaam = clubnaam;
        }
    }
}
