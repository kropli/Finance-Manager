using SQLiteNetExtensions.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Account
    {
        public int Id { get; set; }

        public int UserId { get; set; } 
        public User User { get; set; }

        public int CurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
        
        public List<Expence> Expences { get; set; }

        public List<Income> Incomes { get; set; }
    }
}
