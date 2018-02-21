namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austin",
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    Author = "Jane Austin",
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    Author = "Charles Dickens",
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    Author = "Ursula Le Guin",
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    Author = "Ursula Le Guin",
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    Author = "Ursula Le Guin",
                    Price = 9.95M

                });
            //TODO: Add several Author records
            context.Authors.AddOrUpdate(a => a.AuthorID,
                 new Author()
                 {
                     AuthorID = 1,
                     FirstName = "Mark",
                     LastName = "Twain",
                     Genre = "Fiction"
                 });
            //TODO: Add several Member records
            context.Members.AddOrUpdate(m => m.MemberID,
                 new Member()
                 {
                     MemberID = 1,
                     FirstName = "Ben",
                     LastName = "Bell",
                     Email = "benjamindonbell"
                 });
            //TODO: Add additional Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,

                    //TODO: Add the MemberID value
                    MemberID = 1
                });

        }
    }
}
