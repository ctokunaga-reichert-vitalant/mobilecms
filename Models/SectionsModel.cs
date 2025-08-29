namespace Mobile_CMS.Models
{
    public class SectionsModel
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }
        public string? SectionDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
