namespace NissanPractice.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public ItemsPurchased ItemsPurchasedId { get; set; }
        public Cost CostId { get; set; }
    }
}