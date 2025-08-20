namespace Mobile_CMS.Models
{
    public class ImagesModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public DateTime PublishFromDate { get; set; }
        public DateTime PublishToDate { get; set; }
        public bool IsActive { get; set; }
        public string? BloodType { get; set; }
        public DateTime DonationDate1 { get; set; }
        public DateTime DonationDate2 { get; set; }
        public string? States { get; set; }
        public int ZipCode { get; set; }
        public string? DonorStatus { get; set; }
        public string? DonationType { get; set; }
    }
}
