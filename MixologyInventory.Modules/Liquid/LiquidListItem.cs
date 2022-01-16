using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Liquid
{
    public class LiquidListItem
    {
        public int InventoryID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
