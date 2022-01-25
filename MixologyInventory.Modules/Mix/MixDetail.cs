using MixologyInventory.Model.Drink;
using MixologyInventory.Model.Liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Mix
{
    public class MixDetail
    {
        public int MixID { get; set; }
        public string Name { get; set; }
        public DrinkListItem Drink { get; set; }
        public LiquidListItem Liquid { get; set; }
        public decimal AmountOfDrink { get; set; }
    }
}
