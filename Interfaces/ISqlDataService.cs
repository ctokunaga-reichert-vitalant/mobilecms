using Mobile_CMS.Models;

namespace Mobile_CMS.Interfaces
{
    public interface ISqlDataService
    {
        #region Content Methods
        List<ContentModel> GetContent();
        List<ContentModel> GetContent(bool active);
        ContentModel GetContent(int contentID);
        string InsertContent(ContentModel content);
        string UpdateContent(ContentModel content);
        #endregion
        #region Variable Methods
        List<VariablesModel> GetVariables();
        List<VariablesModel> GetVariables(int section);
        VariablesModel GetVariable(int variableID);
        string InsertVariable(VariablesModel variables);
        string UpdateVariable(VariablesModel variables);
        #endregion
        #region Testimonial Methods
        List<TestimonialsModel> GetTestimonials();
        List<TestimonialsModel> GetTestimonials(bool active);
        TestimonialsModel GetTestimonial(int testimonyID);
        string InsertTestimonial(TestimonialsModel testimonial);
        string UpdateTestimonial(TestimonialsModel testimonial);
        string UploadTestimonialFile(string filepath);
        #endregion
        #region Configuration Methods
        List<ConfigurationModel> GetConfiguration();
        List<ConfigurationModel> GetConfiguration(bool active);
        ConfigurationModel GetConfiguration(int configID);
        string InsertConfiguration(ConfigurationModel configuration);
        string UpdateConfiguration(ConfigurationModel configuration);
        #endregion
        #region Feedback Methods
        List<FeedbackModel> GetFeedback();
        List<FeedbackModel> GetFeedback(bool reviewed);
        FeedbackModel GetFeedback(int contactUsID);
        string ForwardFeedback(FeedbackModel feedback);
        #endregion
        #region Screenshot Methods
        List<ScreenshotsModel> GetScreenshots();
        List<ScreenshotsModel> GetScreenshots(int section);
        ScreenshotsModel GetScreenshot(int id);
        string InsertScreenshot(ScreenshotsModel screenshot);
        string UpdateScreenshot(ScreenshotsModel screenshot);
        string UploadScreenshotFile(string filepath);
        #endregion
        #region Image Methods
        List<ImagesModel> GetImages();
        List<ImagesModel> GetImages(bool active);
        ImagesModel GetImage(int id);
        string InsertImages(ImagesModel images);
        string UpdateImages(ImagesModel images);
        string UploadImageFile(string filepath);
        #endregion
        #region Section Methods
        List<SectionsModel> GetSections();
        List<SectionsModel> GetSections(bool active);
        SectionsModel GetSection(int id);
        string InsertSection(SectionsModel section);
        string UpdateSection(SectionsModel section);
        #endregion
        #region Keyword Methods
        List<KeywordsModel> GetKeywords();
        List<KeywordsModel> GetKeywords(int section);
        KeywordsModel GetKeyword(int id);
        string InsertKeyword(KeywordsModel keyword);
        string UpdateKeyword(KeywordsModel keyword);
        #endregion
        #region MFA Methods
        List<MFAModel> GetMFAStatus();
        List<MFAModel> GetMFAStatus(char lastNameInitial);
        List<MFAModel> GetMFAStatus(string? donorID, string? email, string? lastName, string? firstName);
        MFAModel GetMFAStatus(string email);
        string UpdateMFAStatus(MFAModel mfaStatus);
        string DeactivateMFA();
        #endregion
    }
}
