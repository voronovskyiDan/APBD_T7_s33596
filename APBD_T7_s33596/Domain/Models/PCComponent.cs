namespace APBD_T7_s33596.Domain.Models
{
    public class PCComponent
    {
        public int PCId { get; set; }
        public required PC PC { get; set; } 

        public int ComponentCode { get; set; }
        public required Component Component { get; set; }

        public int Amount { get; set; }

    }
}
