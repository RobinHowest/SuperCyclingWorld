using SuperCyclingWorld.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Wielrenner : Persoon
    {
        public Club Club { get; set; }
        public ICollection<Fiets> Fietsen { get; set; }

        public Wielrenner(string voornaam, string achternaam) : base (voornaam, achternaam)
        {

        }
        public Wielrenner(Club club, string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            Club = club;
        }
    }
}
