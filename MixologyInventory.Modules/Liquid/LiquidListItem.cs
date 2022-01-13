using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Modules.Liquid
{
    public class LiquidListItem
    {
        public int LiquidID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
