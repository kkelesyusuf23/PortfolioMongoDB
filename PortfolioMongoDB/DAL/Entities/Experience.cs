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
        public DateTime DateRange { get; set; }
        public string CompanyName { get; set; }
    }
}
