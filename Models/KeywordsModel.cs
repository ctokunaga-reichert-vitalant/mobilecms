namespace Mobile_CMS.Models
{
    public class KeywordsModel
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string? KeywordName { get; set; }
        public string? KeywordDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
