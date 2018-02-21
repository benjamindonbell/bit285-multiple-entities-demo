using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class BookstoreDbContext : DbContext
    {
     //Constructor - gives the name of the database
        public BookstoreDbContext() : base("IndyBooksMultipleTablesDB") { }

     // Entity representing all the books
        public DbSet<Book> Books { get; set; }

      // Entity representing store members
        public DbSet<Member> Members { get; set; }

     // Entity representing purchases
        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Author> Authors { get; set; }

    }
}