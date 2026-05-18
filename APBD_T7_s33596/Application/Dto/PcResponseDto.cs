namespace APBD_T7_s33596.Application.Dto
{
    public class PcResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Warranty { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int Stock { get; set; }
    }
}
