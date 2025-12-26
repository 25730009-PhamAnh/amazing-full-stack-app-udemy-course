using MongoDB.Bson.Serialization.Attributes;

namespace Amazing.Ecommerce.Catalog.Entities;

public class ProductType : BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; }
}