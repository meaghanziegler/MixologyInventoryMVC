using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string LiquidName { get; set; }

        [Required]
        public decimal LiquidAmount { get; set; }

        [Required]
        public string DrinkName { get; set; }

        [Required]
        public string Directions { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
