namespace Mobile_CMS.Models
{
    public class ContentModel
    {
        public int ContentID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublishFromDate { get; set; }
        public DateTime PublishToDate { get; set; }
        public bool IsActive { get; set; }
        public string? BloodType { get; set; }
        public char PosNeg { get; set; }
        public DateTime DonationDate1 { get; set; }
        public DateTime DonationDate2 { get; set; }
        public string? Region { get; set; }
        public int ZipCode { get; set; }
        public string? DonorStatus { get; set; }
        public string? Tags { get; set; }
        public string? DonationType { get; set; }
    }
}
