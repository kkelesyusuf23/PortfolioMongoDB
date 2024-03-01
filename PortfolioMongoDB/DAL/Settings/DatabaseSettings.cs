namespace PortfolioMongoDB.DAL.Settings
{
    public class DatabaseSettings:IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string ContactInfoCollectionName { get; set; }
        public string CourseCollectionName { get; set; }
        public string EducationCollectionName { get; set; }
        public string ExperienceCollectionName { get; set; }
        public string FeatureCollectionName { get; set; }
        public string MessageCollectionName { get; set; }
        public string ProjectCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string SkillsCollectionName { get; set; }
        public string WorkSpaceCollectionName { get; set; }
    }
}
