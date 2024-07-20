using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expence_tracker.Models {
    public class Transaction {
        [Key]
        public int TransactionID { get; set; }

        //FK from the Category class
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }
        
        public DateTime Date { get; set; } = DateTime.Now;
    }
}