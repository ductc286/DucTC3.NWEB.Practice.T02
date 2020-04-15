namespace DucTC3.NWEB.Practice.T02.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class MyInitializer : CreateDatabaseIfNotExists<MyBaseDbContext>
    {
        ////Init data first
        protected override void Seed(MyBaseDbContext context)
        {
            Category category1 = new Category() { CategoryName = "Gift", Order = 1, Notes = "Gift to friend" };
            Category category2 = new Category() { CategoryName = "CANDLES", Order = 1, Notes = "Notes for CANDLES " };
            Category category3 = new Category() { CategoryName = "FLOWER BUNCHES", Order = 1, Notes = "Notes for FLOWER BUNCHES " };
            Category category4 = new Category() { CategoryName = "MIXED BOUQUET", Order = 1, Notes = "Notes for MIXED BOUQUET " };
            Category category5 = new Category() { CategoryName = "SPECIALS", Order = 1, Notes = "Notes for SPECIALS " };
            Flower flower1 = new Flower()
            {
                CategoryId = 1,
                Name = "Citrus Box",
                Price = 60,
                Description = "Citrus Box Description",
                StoreDate = DateTime.Now,
                StoreInventory = 10,
                Color = "Pink"
            };
            Flower flower2 = new Flower()
            {
                CategoryId = 1,
                Name = "Tulips",
                Price = 50,
                Description = "Tulips Description",
                StoreDate = DateTime.Now,
                StoreInventory = 20,
                Color = "Purple"
            };
            Flower flower3 = new Flower()
            {
                CategoryId = 1,
                Name = "Natives",
                Price = 30,
                Description = "Natives Description",
                StoreDate = DateTime.Now,
                StoreInventory = 14,
                Color = "Pink"
            };
            Flower flower4 = new Flower()
            {
                CategoryId = 3,
                Name = "Tulips",
                Price = 50,
                Description = "Tulips Description",
                StoreDate = DateTime.Now,
                StoreInventory = 20,
                Color = "Red"
            };
            Flower flower5 = new Flower()
            {
                CategoryId = 2,
                Name = "Oriental Lilies",
                Price = 100,
                Description = "Oriental Lilies Description",
                StoreDate = DateTime.Now,
                StoreInventory = 10,
                Color = "Pink"
            };
            context.Categories.AddRange(new List<Category> { category1, category2, category3, category4, category5});
            context.Flowers.AddRange(new List<Flower> { flower1, flower2, flower3, flower4, flower5});

            context.SaveChanges();
            base.Seed(context);
        }
    }
}