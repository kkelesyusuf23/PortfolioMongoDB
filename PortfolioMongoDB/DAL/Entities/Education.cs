using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Education
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EducationID { get; set; }
        public string Divition { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string OrganisationName { get; set; }
    }
}
