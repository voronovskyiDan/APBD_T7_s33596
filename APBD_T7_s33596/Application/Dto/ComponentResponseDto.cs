using APBD_T7_s33596.Domain.Models;

namespace APBD_T7_s33596.Application.Dto
{
    public class ComponentResponseDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }
    }
}
