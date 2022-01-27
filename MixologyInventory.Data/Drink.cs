using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Data
{
    public class Drink
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string DrinkName { get; set; }

        [Display(Name = "Liquid Name")]
        public string LiquidName { get; set; }

        [Display(Name = "Liquid Amount (oz)")]
        public decimal LiquidAmount { get; set; }

        public virtual List<Mix> IngredientsInDrink { get; set; } = new List<Mix>();

        [Required]
        public string Directions { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
