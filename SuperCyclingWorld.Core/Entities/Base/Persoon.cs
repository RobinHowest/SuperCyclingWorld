using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities.Base
{
    public abstract class Persoon
    {
        public Guid Id { get; protected set; }
        public string Voornaam { get; protected set; }
        public string Achternaam { get; protected set; }
        public DateTime GeboorteDatum { get; protected set; }
        public string Paswoord { get; protected set; }

        public ICollection<FanRegistratie> Wielrenners { get; protected set; }
        public Persoon()
        {
            Id = Guid.NewGuid();
        }

        public Persoon(string voornaam, string achternaam, string paswoord)
        {
            Id = Guid.NewGuid();
            Voornaam = voornaam;
            Achternaam = achternaam;
            Paswoord = paswoord;
        }
    }
}
