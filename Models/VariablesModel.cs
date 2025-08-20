namespace Mobile_CMS.Models
{
    public class VariablesModel
    {
        public int VariableId { get; set; }
        public int Section { get; set; }
        public int Keyword { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public bool IsActive { get; set; }
    }
}
