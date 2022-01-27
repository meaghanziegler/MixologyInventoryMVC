using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Data
{
    public class Mix
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Liquid))]
        public int LiquidID { get; set; }
        public virtual Liquid Liquid { get; set; }

        //public virtual List<Liquid> Liquids { get; set; } = new List<Liquid>();

        [Required]
        [ForeignKey(nameof(Drink))]
        public int DrinkID { get; set; }
        public virtual Drink Drink { get; set; }

        [Required]
        [Display(Name = "Amount of Drink (oz)")]
        public decimal AmountOfDrink { get; set; }

        //[Display(Name="Total Liquid Needed")]
        //public decimal TotalLiquid {
        //    get
        //    {
        //        return Math.Round(Drink.LiquidAmount * AmountOfDrink, 2);
        //    }
        //}


    }
}
