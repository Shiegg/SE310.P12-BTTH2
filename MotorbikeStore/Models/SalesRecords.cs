namespace MotorbikeStore.Models
{
    public class SalesRecords
    {
        public int SaleId { get; set; }
        public int MotorbikeId { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }

        // Thiết lập mối quan hệ với Motorbike
        public Motorbike Motorbike { get; set; }
    }
}
