using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Account
    {
        public string Id { get; set; }

        public Currency Currency { get; set; }

        [Column(TypeName = "money")]
        public decimal CurrencyAmount { get; set; }

        List<Spending> Spendings { get; set; }

        List<Income> Incomes { get; set; }
    }
}
