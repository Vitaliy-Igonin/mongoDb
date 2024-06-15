using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDB.Model
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Name { get; set; } = string.Empty;    
        public string Adress { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
