using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Income
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public string IncomeAmount { get; set; }
    }
}
