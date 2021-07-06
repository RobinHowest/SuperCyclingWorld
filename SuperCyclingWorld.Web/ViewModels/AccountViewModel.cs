using SocialCyclingWorld.Web.Data;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
using SuperCyclingWorld.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class AccountViewModel
    {
        public Guid Id { get;  set; }
        public string Voornaam { get; set; }
        public string Achternaam { get;  set; }
        public Club Club { get; private set; } = null;
        public ICollection<Club> Clubs { get; private set; }
        public ICollection<FanRegistratie> Wielrenners { get;  set; }
        public string AccountType { get; private set; }
        public int Leeftijd { get; private set; }
        public ICollection<Fiets> Fietsen { get; private set; } = new List<Fiets>();
        public List<AccountTile> AccountTiles { get; set; } = new List<AccountTile>();
        public int SelectedAccountTile { get; set; } = 0;
        public AccountViewModel(Persoon account, ICollection<AccountTile>accountTiles)
        {
   
            Id = account.Id;
            Voornaam = account.Voornaam;
            Achternaam = account.Achternaam;
            Wielrenners = account.Wielrenners;
            Leeftijd = DateTime.Now.Year - account.GeboorteDatum.Year;
            SetAccount(account);
            GetAccountTiles(accountTiles);
            

        }

        private void SetAccount(Persoon account)
        {

            if (account is Wielrenner)
            { 
                AccountType = "Wielrenner";
                Wielrenner convertedPersoon = (Wielrenner)account;
                Club = convertedPersoon.Club;
                Wielrenners = convertedPersoon.Wielrenners;
                Fietsen = convertedPersoon.Fietsen;
            }

            else
            {
                AccountType = "Supporter";
                Supporter convertedPersoon = (Supporter)account;
                Wielrenners = convertedPersoon.Wielrenners;
                Clubs = (ICollection<Club>)convertedPersoon.Clubs;
                Wielrenners = convertedPersoon.Wielrenners;

            }
        }

        private void GetAccountTiles(ICollection<AccountTile> accountTiles)
        {
            if(AccountType == "Wielrenner")
            {
                foreach(AccountTile accountTile in accountTiles)
                {
                    if(accountTile.TyleType == TileType.Wielrenner || accountTile.TyleType == TileType.Persoon)
                    {
                        AccountTiles.Add(accountTile);
                    }
                }
            }
            else
            {
                foreach (AccountTile accountTile in accountTiles)
                {
                    if (accountTile.TyleType == TileType.Supporter || accountTile.TyleType == TileType.Persoon)
                    {
                        AccountTiles.Add(accountTile);
                    }
                }
            }
           
        }

    }
}
