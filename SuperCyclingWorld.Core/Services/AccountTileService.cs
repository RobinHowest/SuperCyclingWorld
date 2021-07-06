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
        public ICollection<string> AccountTilesContent { get; private set; }


        public AccountTileService()
        {
            AccountTiles = GenerateTiles();
            AccountTilesContent = GenerateTileContents();
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

        private List<string> GenerateTileContents()
        {
            List<string> tileContents = new List<string>();
            tileContents.Add("<h2 style='border - bottom: dotted 3px black'>Profiel</h2><br/><br/><h3>@Model.AccountType</h3 >< br/><p style = 'padding-left:20px;'>@Model.Voornaam @Model.Achternaam</p>" +
                    "<br/><p style = 'padding-left:20px;'> Leeftijd: @Model.Leeftijd jaar</p><br/>@if(Model.Club != null){<h3>Club</h3><br/><p style = 'padding-left:20px;' > @Model.Club.Clubnaam </p>}");

            return tileContents;
        }

    }
}
