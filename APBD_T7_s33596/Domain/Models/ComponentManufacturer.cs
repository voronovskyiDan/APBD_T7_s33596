namespace APBD_T7_s33596.Domain.Models
{
    public class ComponentManufacturer
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public DateOnly FoundationDate { get; set; }

        public List<Component> Components { get; set; } = [];
    }
}
