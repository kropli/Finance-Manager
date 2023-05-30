using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Account
    {
        public int Id { get; set; }

        public Currency Currency { get; set; }

        [Column(TypeName = "money")]
        public decimal CurrencyAmount { get; set; }

        public List<Spending> Spendings { get; set; }

        public List<Income> Incomes { get; set; }
    }
}
