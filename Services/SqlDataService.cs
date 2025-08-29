using Mobile_CMS.Interfaces;
using Mobile_CMS.Models;

namespace Mobile_CMS.Services
{
    public class SqlDataService : ISqlDataService
    {
        private readonly ILogger<SqlDataService> _logger;

        private readonly IConfiguration _config;
        private string? SqlConnection { get; set; }
        public SqlDataService(ILogger<SqlDataService> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
            SqlConnection = _config.GetConnectionString("MktSqlConnectionString");
        }

        public List<ContentModel> GetContent()
        {
            List<ContentModel> contents = new List<ContentModel>();

            return contents;
        }

        public List<ContentModel> GetContent(bool active)
        {
            List<ContentModel> contents = new List<ContentModel>();

            return contents;
        }

        public ContentModel GetContent(int contentID)
        {
            ContentModel content = new ContentModel();

            return content;
        }

        public string InsertContent(ContentModel content)
        {
            return "success";
        }

        public string UpdateContent(ContentModel content)
        {
            return "success";
        }

        public List<VariablesModel> GetVariables()
        {
            List<VariablesModel> variables = new List<VariablesModel>();

            return variables;
        }

        public List<VariablesModel> GetVariables(int section)
        {
            List<VariablesModel > variables = new List<VariablesModel>();

            return variables;
        }

        public VariablesModel GetVariable(int variableID)
        {
            VariablesModel variable = new VariablesModel();

            return variable;
        }

        public string InsertVariable(VariablesModel variables)
        {
            return "success";
        }

        public string UpdateVariable(VariablesModel variables)
        {
            return "success";
        }

        public List<TestimonialsModel> GetTestimonials()
        {
            List<TestimonialsModel> testimonials = new List<TestimonialsModel>();

            return testimonials;
        }

        public List<TestimonialsModel> GetTestimonials(bool active)
        {
            List<TestimonialsModel> testimonials = new List<TestimonialsModel>();

            return testimonials;
        }

        public TestimonialsModel GetTestimonial(int testimonyID)
        {
            TestimonialsModel testimony = new TestimonialsModel();

            return testimony;
        }

        public string InsertTestimonial(TestimonialsModel testimonial)
        {
            return "success";
        }

        public string UpdateTestimonial(TestimonialsModel testimonial)
        {
            return "success";
        }

        public string UploadTestimonialFile(string filepath)
        {
            return "success";
        }

        public List<ConfigurationModel> GetConfiguration()
        {
            List<ConfigurationModel> configs = new List<ConfigurationModel>();

            return configs;
        }

        public List<ConfigurationModel> GetConfiguration(bool active)
        {
            List<ConfigurationModel> configs = new List<ConfigurationModel>();

            return configs;
        }

        public ConfigurationModel GetConfiguration(int configID)
        {
            ConfigurationModel config = new ConfigurationModel();

            return config;
        }

        public string InsertConfiguration(ConfigurationModel configuration)
        {
            return "success";
        }

        public string UpdateConfiguration(ConfigurationModel configuration)
        {
            return "success";
        }

        public List<FeedbackModel> GetFeedback()
        {
            List<FeedbackModel> feedback = new List<FeedbackModel>();

            return feedback;
        }

        public List<FeedbackModel> GetFeedback(bool reviewed)
        {
            List<FeedbackModel> feedback = new List<FeedbackModel>();

            return feedback;
        }

        public FeedbackModel GetFeedback(int contactUsID)
        {
            FeedbackModel feedback = new FeedbackModel();

            return feedback;
        }

        public string ForwardFeedback(FeedbackModel feedback)
        {
            return "success";
        }

        public List<ScreenshotsModel> GetScreenshots()
        {
            List<ScreenshotsModel> screenshots = new List<ScreenshotsModel>();

            return screenshots;
        }

        public List<ScreenshotsModel> GetScreenshots(int section)
        {
            List<ScreenshotsModel> screenshots = new List<ScreenshotsModel>();

            return screenshots;
        }

        public ScreenshotsModel GetScreenshot(int id)
        {
            ScreenshotsModel screenshot = new ScreenshotsModel();

            return screenshot;
        }

        public string InsertScreenshot(ScreenshotsModel screenshot)
        {
            return "success";
        }

        public string UpdateScreenshot(ScreenshotsModel screenshot)
        {
            return "success";
        }

        public string UploadScreenshotFile(string filepath)
        {
            return "success";
        }

        public List<ImagesModel> GetImages()
        {
            List<ImagesModel> images = new List<ImagesModel>();

            return images;
        }

        public List<ImagesModel> GetImages(bool active)
        {
            List<ImagesModel> images = new List<ImagesModel>();

            return images;
        }

        public ImagesModel GetImage(int id)
        {
            ImagesModel image = new ImagesModel();

            return image;
        }

        public string InsertImages(ImagesModel images)
        {
            return "success";
        }

        public string UpdateImages(ImagesModel images)
        {
            return "success";
        }

        public string UploadImageFile(string filepath)
        {
            return "success";
        }

        public List<SectionsModel> GetSections()
        {
            List<SectionsModel> sections = new List<SectionsModel>();

            return sections;
        }

        public List<SectionsModel> GetSections(bool active)
        {
            List<SectionsModel> sections = new List<SectionsModel>();

            return sections;
        }

        public SectionsModel GetSection(int id)
        {
            SectionsModel section = new SectionsModel();

            return section;
        }

        public string InsertSection(SectionsModel section)
        {
            return "success";
        }

        public string UpdateSection(SectionsModel section)
        {
            return "success";
        }

        public List<KeywordsModel> GetKeywords()
        {
            List<KeywordsModel> keywords = new List<KeywordsModel>();

            return keywords;
        }

        public List<KeywordsModel> GetKeywords(int section)
        {
            List<KeywordsModel> keywords = new List<KeywordsModel>();

            return keywords;
        }

        public KeywordsModel GetKeyword(int id)
        {
            KeywordsModel keyword = new KeywordsModel();

            return keyword;
        }

        public string InsertKeyword(KeywordsModel keyword)
        {
            return "success";
        }

        public string UpdateKeyword(KeywordsModel keyword)
        {
            return "success";
        }

        public List<MFAModel> GetMFAStatus()
        {
            List<MFAModel> mfaStatuses = new List<MFAModel>();

            return mfaStatuses;
        }

        public List<MFAModel> GetMFAStatus(char lastNameInitial)
        {
            List<MFAModel> mfaStatuses = new List<MFAModel>();

            return mfaStatuses;
        }

        public List<MFAModel> GetMFAStatus(string? donorID, string? email, string? lastName, string? firstName)
        {
            List<MFAModel> mfaStatuses = new List<MFAModel>();

            return mfaStatuses;
        }

        public MFAModel GetMFAStatus(string email)
        {
            MFAModel mfaStatus = new MFAModel();

            return mfaStatus;
        }

        public string UpdateMFAStatus(MFAModel mfaStatus)
        {
            return "success";
        }

        public string DeactivateMFA()
        {
            return "success";
        }
    }
}
