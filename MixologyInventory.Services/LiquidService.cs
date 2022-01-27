using MixologyInventory.Data;
using MixologyInventory.Model;
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
                    LiquidType = (int)model.LiquidType,
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

        public LiquidDetail GetLiquidById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Liquids
                        .Single(e => e.ID == id);
                return
                    new LiquidDetail
                    {
                        InventoryID = entity.ID,
                        Brand = entity.Brand,
                        Name = entity.Name,
                        Amount = entity.Amount,
                        LiquidType = ((LiquidType)entity.LiquidType).ToString(),
                        Proof = entity.Proof,
                        Comment = entity.Comment
                    };
            }
        }

        public bool UpdateLiquid(LiquidEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Liquids
                        .Single(e => e.ID == model.InventoryID);

                entity.ID = model.InventoryID;
                entity.Brand = model.Brand;
                entity.Name = model.Name;
                entity.Amount = model.Amount;
                entity.LiquidType = (int)model.LiquidType;
                entity.Proof = model.Proof;
                entity.Comment = model.Comment;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteLiquid(int liquidId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Liquids
                        .Single(e => e.ID == liquidId);

                ctx.Liquids.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
