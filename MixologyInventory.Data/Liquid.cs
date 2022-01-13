using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Data
{
    public class Liquid
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public int LiquidType { get; set; }

        [Required]
        public decimal Proof { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
