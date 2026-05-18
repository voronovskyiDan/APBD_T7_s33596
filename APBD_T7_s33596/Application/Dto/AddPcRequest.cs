using System.ComponentModel.DataAnnotations;

namespace APBD_T7_s33596.Application.Dto
{
    public class AddPcRequest
    {
        [Required]
        public string? Name { get; set; }

        [Range(0.1, double.MaxValue)]
        public double Weight { get; set; }

        [Range(1, int.MaxValue)]
        public int Warranty { get; set; }

        [Required]
        public DateTime? CreatedAt { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
    }
}
