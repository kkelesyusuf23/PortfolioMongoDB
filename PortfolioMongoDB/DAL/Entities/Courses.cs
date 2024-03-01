using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PortfolioMongoDB.DAL.Entities
{
    public class Courses
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourseID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Link { get; set; }
    }
}
