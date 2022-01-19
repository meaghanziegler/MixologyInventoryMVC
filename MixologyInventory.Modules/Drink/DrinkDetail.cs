using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkDetail
    {
        public int RecipeID { get; set; }
        public string DrinkName { get; set; }
        public string LiquidName { get; set; }
        public decimal LiquidAmount { get; set; }
        public string Directions { get; set; }
        public string Description { get; set; }
    }
}
