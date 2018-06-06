using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rejestracja_na_praktyki_w_Billennium.Models
{
    public class Praktykant
    {
        public int PraktykantId { get; set; }
        [Required(ErrorMessage = "Pole wymagane.")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole wymagane.")]
        [StringLength(1000)]
        public string Note { get; set; }
    }
}