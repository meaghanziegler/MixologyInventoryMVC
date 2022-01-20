using MixologyInventory.Data;
using MixologyInventory.Model.Mix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Services
{
    public class MixService
    {
        private readonly Guid _userId;

        public MixService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateMix(MixCreate model)
        {
            var entity =
                new Mix()
                {
                    Name = model.Name,
                    DrinkID = model.DrinkID,
                    LiquidID = model.LiquidID,
                    Amount = model.Amount
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Mixes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MixListItem> GetMixes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Mixes.Select(e => new MixListItem
                {
                    MixID = e.ID,
                    Name = e.Name
                }).ToArray();
            }
        }

        public MixDetail GetMixById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Mixes.Single(e => e.ID == id);
                return
                    new MixDetail
                    {
                        MixID = entity.ID,
                        Name = entity.Name,
                        Drink = new Model.Drink.DrinkListItem
                        {
                            RecipeID = entity.Drink.ID,
                            DrinkName = entity.Drink.DrinkName,
                            Description = entity.Drink.Description
                        },
                        Liquid = new Model.Liquid.LiquidListItem
                        {
                            InventoryID = entity.Liquid.ID,
                            Brand = entity.Liquid.Brand,
                            Name = entity.Liquid.Name,
                            Amount = entity.Liquid.Amount
                        },
                        Amount = entity.Amount
                    };
            }
        }
    }
}
