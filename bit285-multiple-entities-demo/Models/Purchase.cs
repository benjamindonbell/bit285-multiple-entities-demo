using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }
        public decimal Amount { get; set; } // The purchase price of the book
        public int BookID { get; set; }     // The book purchased
        public  int MemberID { get; set; }
    }
}