using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class ChartBox
    {

        public string Name { get; set; }
        public string Picture { get; set; }

        public ChartBox(string name, string picture)
        {
            Name = name;
            Picture = picture;
        }
    }
}
