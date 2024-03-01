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
        public DateTime DateRange { get; set; }
        public string OrganisationName { get; set; }
    }
}
