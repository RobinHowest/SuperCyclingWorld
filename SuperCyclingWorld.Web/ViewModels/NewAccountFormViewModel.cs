using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class NewAccountFormViewModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Email { get; set; }
        public string Paswoord { get; set; }
        public string RepeatPaswoord { get; set; }
        public string RegisteredAS { get; set; }
        public Guid? ClubId { get; set; } = null;
    }
}
