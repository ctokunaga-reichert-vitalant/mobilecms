namespace Mobile_CMS.Models
{
    public class ConfigurationModel
    {
        public int ConfigId { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
        public int IsActive { get; set; }
    }
}
