using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities.Base
{
    public abstract class Persoon
    {
        public Guid Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public ICollection<Wielrenner> Wielrenners { get; set; }

        public Persoon()
        {
            Id = Guid.NewGuid();
        }

        public Persoon(string voornaam, string achternaam)
        {
            Id = Guid.NewGuid();
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
    }
}
