using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkDetail
    {
        public int RecipeID { get; set; }

        [Display(Name ="Drink Name")]
        public string DrinkName { get; set; }

        //[Display(Name ="Liquid Name")]
        //public string LiquidName { get; set; }

        //[Display(Name ="Liquid Amount (oz)")]
        //public decimal LiquidAmount { get; set; }

        //public List<string> IngredientNameInDrink { get; set; } = new List<string>();

        public string Directions { get; set; }

        public string Description { get; set; }
    }
}
