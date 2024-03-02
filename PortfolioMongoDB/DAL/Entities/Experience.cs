using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Experience
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ExperienceID { get; set; }
        public string Divition { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string CompanyName { get; set; }
    }
}
