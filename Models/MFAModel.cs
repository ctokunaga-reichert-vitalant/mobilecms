namespace Mobile_CMS.Models
{
    public class MFAModel
    {
        public string? Email { get; set; }
        public string? DonorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public bool MFAEnabled { get; set; }
    }
}
