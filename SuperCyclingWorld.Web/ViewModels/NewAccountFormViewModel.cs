using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class NewAccountFormViewModel
    {
        [Required(ErrorMessage ="*")]
        public string Voornaam { get; set; }
        [Required(ErrorMessage = "*")]
        public string Achternaam { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true, NullDisplayText = "NULL")]
        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get; set; }
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage ="Dit email adres is niet correct !")]
        public string Email { get; set; }
        [Required(ErrorMessage = " * ")]
        public string Paswoord { get; set; }
        [Required(ErrorMessage = "*")]
        public string RepeatPaswoord { get; set; }
        [Required(ErrorMessage = "*")]
        public string RegisteredAS { get; set; }
        public Guid? ClubId { get; set; } = null;
        public List<Club> Clubs { get; set; }
    }
}
