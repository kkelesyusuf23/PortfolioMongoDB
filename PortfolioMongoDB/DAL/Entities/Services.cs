using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Services
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServicesID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
