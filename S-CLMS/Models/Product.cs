using System.ComponentModel;

namespace S_CLMS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Version { get; set; }
        public string? Description { get; set; }
        public ICollection<License>? Licenses { get; set; }
    }
}

