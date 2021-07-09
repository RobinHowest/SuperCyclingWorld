using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class Rit
    {
        public Guid Id { get; set; }
        public Guid PersoonId { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string Aankomst { get; set; }
    }
}
