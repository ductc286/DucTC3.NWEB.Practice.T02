namespace DucTC3.NWEB.Practice.T02.Core.Models
{
    using System.Data.Entity;
    public class MyBaseDbContext : DbContext
    {
        public MyBaseDbContext() : base("MyDB")
        {
            Database.SetInitializer<MyBaseDbContext>(new MyInitializer());
        }

        //static BookStoreDbContext()
        //{
        //    Database.SetInitializer<JustBlogContext>(new JustBlogInitializer());
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Flower> Flowers { get; set; }

    }
}