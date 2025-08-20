namespace Mobile_CMS.Models
{
    public class ScreenshotsModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Section { get; set; }
        public int Keyword { get; set; }
        public string? Screenshot { get; set; }
        public bool IsActive { get; set; }
    }
}
