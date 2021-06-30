using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Fiets
    {
        public string Zadel { get; set; }
        public string Merk { get; set; }

        public Fiets(string zadel, string merk)
        {
            Zadel = zadel;
            Merk = merk;
        }
    }
}
