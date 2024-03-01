using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Skills
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SkillsID { get; set; }
        public string SkillTitle { get; set; }

    }
}
