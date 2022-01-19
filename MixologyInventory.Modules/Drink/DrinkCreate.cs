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
        public string DrinkName { get; set; }
        public string LiquidName { get; set; }
        public decimal LiquidAmount { get; set; }
        public string Directions { get; set; }
        public string Description { get; set; }
    }
}
