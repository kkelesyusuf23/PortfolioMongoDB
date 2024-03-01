using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Projects
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProjectID { get; set; }
        public string Title { get; set; }
        public string GithubLink { get; set; }
    }
}
