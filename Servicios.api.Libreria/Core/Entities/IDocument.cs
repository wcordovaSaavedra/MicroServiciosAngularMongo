using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Servicios.api.Libreria.Core.Entities
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; }
        DateTime CreatedDate { get; }
    }
}
