using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkEdit
    {
        public int RecipeID { get; set; }

        [MaxLength(100, ErrorMessage = "Name is way to long, shorten that shit up.")]
        public string DrinkName { get; set; }

        public string Directions { get; set; }

        public string Description { get; set; }
    }
}
