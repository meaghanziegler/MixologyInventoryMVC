using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name="Amount of Drink (oz)")]
        public decimal AmountOfDrink { get; set; }

        //[Display(Name="Total Liquid Needed")]
        //public decimal TotalLiquid { get; set; }
    }
}
