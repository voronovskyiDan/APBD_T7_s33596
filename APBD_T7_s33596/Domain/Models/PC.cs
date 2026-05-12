namespace APBD_T7_s33596.Domain.Models
{
    public class PC
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Warranty { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Stock { get; set; }

        public List<PCComponent> PCComponents { get; set; } = [];
    }
}
