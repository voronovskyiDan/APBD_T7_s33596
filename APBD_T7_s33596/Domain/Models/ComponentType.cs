namespace APBD_T7_s33596.Domain.Models
{
    public class ComponentType
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public List<Component> Components { get; set; } = [];
    }
}
