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
        public int LiquidID { get; set; }

        [ForeignKey(nameof(LiquidID))]
        public virtual Liquid Liquid { get; set; }

        [Required]
        public int DrinkID { get; set; }

        [ForeignKey(nameof(DrinkID))]
        public virtual Drink Drink { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
