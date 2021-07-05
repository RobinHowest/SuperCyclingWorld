using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
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
        public ICollection<FanRegistratie> Wielrenners { get;  set; }
        public string AccountType { get; private set; }
        public int Leeftijd { get; private set; }
        public AccountViewModel(Persoon account)
        {
            Id = account.Id;
            Voornaam = account.Voornaam;
            Achternaam = account.Achternaam;
            Wielrenners = account.Wielrenners;
            Leeftijd = DateTime.Now.Year - account.GeboorteDatum.Year;
            SetAccountTypeAndClub(account);

        }

        private void SetAccountTypeAndClub(Persoon account)
        {

            if (account is Wielrenner)
            { 
                AccountType = "Wielrenner";
                Wielrenner convertedPersoon = (Wielrenner)account;
                Club = convertedPersoon.Club;

            }

            else
            {
                AccountType = "Supporter";
                Supporter convertedPersoon = (Supporter)account;
                
            }
        }




    }
}
