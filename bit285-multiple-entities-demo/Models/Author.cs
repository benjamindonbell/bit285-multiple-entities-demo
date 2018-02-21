using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        // TODO: Create at least three  appropriate properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genre { get; set; }

        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"

        public virtual ICollection<Book> WrittenBooks { get; set; }
    }
}