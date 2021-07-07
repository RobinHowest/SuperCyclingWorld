using SocialCyclingWorld.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Paswoord { get; set; }
        [Required(ErrorMessage = "*")]
        public string Email_UserName { get; set; }

    }
}
