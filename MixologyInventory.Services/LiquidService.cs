using MixologyInventory.Data;
using MixologyInventory.Model.Liquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Services
{
    public class LiquidService
    {
        private readonly Guid _userId;

        public LiquidService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLiquid(LiquidCreate model)
        {
            var entity =
                new Liquid()
                {
                    Brand = model.Brand,
                    Name = model.Name,
                    Amount = model.Amount,
                    LiquidType = model.LiquidType,
                    Proof = model.Proof,
                    Comment = model.Comment
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Liquids.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LiquidListItem> GetLiquids()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Liquids.Select(e => new LiquidListItem
                {
                    InventoryID = e.ID,
                    Brand = e.Brand,
                    Name = e.Name,
                    Amount = e.Amount
                }).ToArray();
            }
        }
    }
}
