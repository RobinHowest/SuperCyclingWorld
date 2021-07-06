using SuperCyclingWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class AccountTile
    {
        public byte Id { get; set; }
        public TileType TyleType { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }

    }
}
