using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Eindtest.Models
{
    public class CBUserModel
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Postcode is required")]
        public int Postcode { get; set; }
    }
}
