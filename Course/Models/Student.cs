using MongoDB.Bson.Serialization.Attributes;

namespace CourseApp.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id{ get; set; }
        public int student_id { get; set; }

        public string name { get; set; }

        public float average { get; set; }
    }
}
