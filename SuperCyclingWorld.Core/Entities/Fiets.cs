using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Fiets
    {
        public Guid Id { get; private set; }
        public string Zadel { get; set; }
        public string Merk { get; set; }
        public Guid WielrennerId { get; private set; }

        private Fiets()
        {

        }

        public Fiets(Wielrenner wielrenner, string merk, string zadel)
        {
            Id = Guid.NewGuid();
            WielrennerId = wielrenner.Id;
            Merk = merk;
            Zadel = zadel;
        }
    }
}
