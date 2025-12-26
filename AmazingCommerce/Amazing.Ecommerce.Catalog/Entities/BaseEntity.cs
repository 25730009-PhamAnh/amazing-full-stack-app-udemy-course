using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Amazing.Ecommerce.Catalog.Entities;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}