using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Mix
{
    public class MixEdit
    {
        public int MixID { get; set; }
        public string Name { get; set; }
        public int DrinkID { get; set; }
        public int LiquidID { get; set; }
        public decimal Amount { get; set; }
    }
}
