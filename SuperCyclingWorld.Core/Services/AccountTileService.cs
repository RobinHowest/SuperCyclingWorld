using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Services
{
    public class AccountTileService
    {
        public List<AccountTile> AccountTiles { get; private set; } = new List<AccountTile>();

        public AccountTileService()
        {
            AccountTiles = GenerateTiles();

        }

        private List<AccountTile> GenerateTiles()
        {

            string[] tileNames = { "Profiel", "Fietsen", "Statestieken", "Ritten", "Clubs", "Wielrenners", "Club" };
            TileType[] tileTypes = { TileType.Persoon, TileType.Wielrenner, TileType.Wielrenner, TileType.Wielrenner, TileType.Supporter, TileType.Supporter, TileType.Wielrenner };
            string[] tilePictos = { "/images/functionalImages/profielPicto.png", "/images/functionalImages/clubPicto.png", "/images/functionalImages/statisticPicto.png", "/images/functionalImages/rittenPicto.png", "/images/functionalImages/clubPicto.png", "/images/functionalImages/clubPicto.png", "/images/functionalImages/oneClubPicto.png"  };

            List<AccountTile> tiles = new List<AccountTile>();

            for(byte i = 0; i < tileNames.Length; i++)
            {
                tiles.Add(new AccountTile { Id = i, Name = tileNames[i], TyleType = tileTypes[i], Picture = tilePictos[i]});
            }

            return tiles;
        }

    }
}
