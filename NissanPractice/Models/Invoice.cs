namespace NissanPractice.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public ItemsPurchased ItemsPurchased { get; set; }
        public Cost Cost { get; set; }
    }
}