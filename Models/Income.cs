using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Income
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public string Source { get; set; }
    }
}
