namespace S_CLMS.Models
{
    public class License
    {
        public int LicenseId { get; set; }
        public string? Key { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
