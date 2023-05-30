using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Spending
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal SpendingAmount { get; set; }
    }
}
