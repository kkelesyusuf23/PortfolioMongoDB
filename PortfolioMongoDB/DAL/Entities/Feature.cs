using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Job { get; set; }
        public string CVLink { get; set; }
        public string VideoLink { get; set; }
        public string ImageURL { get; set; }
    }
}
