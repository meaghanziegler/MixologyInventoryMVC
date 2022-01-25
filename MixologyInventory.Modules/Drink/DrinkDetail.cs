using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Drink
{
    public class DrinkDetail
    {
        public int RecipeID { get; set; }

        public string DrinkName { get; set; }

        public List<string> Liquids { get; set; }

        public string Directions { get; set; }

        public string Description { get; set; }
    }
}
