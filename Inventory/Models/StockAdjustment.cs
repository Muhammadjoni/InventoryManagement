namespace Inventory.Models
{
    public class StockAdjustment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AdjustedQuantity { get; set; } // Positive for addition, negative for reduction
        public string Reason { get; set; } // "Audit", "Damage", etc.
        public DateTime AdjustmentDate { get; set; }
        public string AdjustedBy { get; set; } // Optional: Name of the person performing the adjustment
    }
}
