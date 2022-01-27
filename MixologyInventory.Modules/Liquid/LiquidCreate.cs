using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Model.Liquid
{
    public class LiquidCreate
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name="Liquid Type")]
        public LiquidType LiquidType { get; set; }

        [Required]
        public decimal Proof { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Dude. Just tell me what you think about this specific liquid. It's not that hard.")]
        public string Comment { get; set; }
    }
}
