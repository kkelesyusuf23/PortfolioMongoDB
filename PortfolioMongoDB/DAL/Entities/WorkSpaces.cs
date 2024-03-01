using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class WorkSpaces
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string WorkSpacesID { get; set; }
        public string Title { get; set; }
    }
}
