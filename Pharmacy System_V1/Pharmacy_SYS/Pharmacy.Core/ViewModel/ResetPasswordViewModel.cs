using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core.ViewModel
{
    public class ResetPasswordViewModel
    {

        public string Token { get; set; } = null!;
        [StringLength(60, MinimumLength = 5)]
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        [StringLength(60, MinimumLength = 5)]
        public string ConfirmPassword { get; set; } = null!;
    }
}
