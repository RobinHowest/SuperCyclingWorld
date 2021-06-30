using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities.Base
{
    public abstract class Persoon
    {
        public Guid Id { get; private set; }
        public string Voornaam { get; protected set; }
        public string Achternaam { get; protected set; }
        public ICollection<Wielrenner> Wielrenners { get; protected set; }

        public Persoon(string voornaam, string achternaam)
        {
            Id = Guid.NewGuid();
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
    }
}
