namespace APBD_T7_s33596.Domain.Models
{
    public class Component
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int ComponentManufacturerId { get; set; }
        public ComponentManufacturer? ComponentManufacturer { get; set; }

        public int ComponentTypeId { get; set; }
        public ComponentType? ComponentType { get; set; }

        public List<PCComponent> PCComponents { get; set; } = [];
    }
}
