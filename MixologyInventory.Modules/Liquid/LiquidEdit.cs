using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Liquid
{
    public class LiquidEdit
    {
        public int InventoryID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int LiquidType { get; set; }
        public decimal Proof { get; set; }
        public string Comment { get; set; }
    }
}
