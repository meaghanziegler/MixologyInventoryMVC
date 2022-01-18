using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Liquid
{
    public class LiquidDetail
    {
        public int LiquidID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }

        [Display(Name="Amount (oz)")]
        public decimal Amount { get; set; }
        public int LiquidType { get; set; }
        public decimal Proof { get; set; }
        public string Comment { get; set; }
    }
}
