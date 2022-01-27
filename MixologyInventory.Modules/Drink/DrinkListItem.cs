using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkListItem
    {
        public int RecipeID { get; set; }
        [Display(Name="Drink Name")]
        public string DrinkName { get; set; }
        public string Description { get; set; }
    }
}
