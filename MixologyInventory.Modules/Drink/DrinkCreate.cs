using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name is way to long man, shorten that shit up.")]
        public string DrinkName { get; set; }

        [Required]
        public string Directions { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
