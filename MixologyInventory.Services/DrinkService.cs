using MixologyInventory.Data;
using MixologyInventory.Model.Drink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixologyInventory.Services
{
    public class DrinkService
    {
        private readonly Guid _userId;

        public DrinkService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDrink(DrinkCreate model)
        {
            var entity =
                new Drink()
                {
                    DrinkName = model.DrinkName,
                    LiquidName = model.LiquidName,
                    LiquidAmount = model.LiquidAmount,
                    Directions = model.Directions,
                    Description = model.Description
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Drinks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<DrinkListItem> GetDrinks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Drinks.Select(e => new DrinkListItem
                {
                    RecipeID = e.ID,
                    DrinkName = e.DrinkName,
                    Description = e.Description
                }).ToArray();
            }
        }

        public DrinkDetail GetDrinkById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drinks
                        .Single(e => e.ID == id);
                return
                    new DrinkDetail
                    {
                        RecipeID = entity.ID,
                        DrinkName = entity.DrinkName,
                        LiquidName = entity.LiquidName,
                        LiquidAmount = entity.LiquidAmount,
                        Directions = entity.Directions,
                        Description = entity.Description
                    };
            }
        }

        public bool UpdateDrink(DrinkEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drinks
                        .Single(e => e.ID == model.RecipeID);

                entity.DrinkName = model.DrinkName;
                entity.LiquidName = model.LiquidName;
                entity.LiquidAmount = model.LiquidAmount;
                entity.Directions = model.Directions;
                entity.Description = model.Decription;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDrink(int recipeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Drinks
                        .Single(e => e.ID == recipeId);

                ctx.Drinks.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
