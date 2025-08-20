namespace Mobile_CMS.Models
{
    public class FeedbackModel
    {
        public int ContactUsID { get; set; }
        public string? Email { get; set; }
        public string? DonorID { get; set; }
        public string? Feedback {  get; set; }
        public DateTime DateSubmitted { get; set; }
        public bool Reviewed { get; set; }
    }
}
