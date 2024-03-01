using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class ContactInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactInfoID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
