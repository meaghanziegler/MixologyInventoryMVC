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
        [Display(Name ="Drink Name")]
        public string DrinkName { get; set; }

        //public int LiquidID { get; set; }

        //[Display(Name ="Liquid Name")]
        //public string LiquidName { get; set; }

        //[Display(Name ="Liquid Amount (oz)")]
        //public decimal LiquidAmount { get; set; }

        [Required]
        public string Directions { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
