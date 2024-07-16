namespace Servicios.api.Libreria.Core.Entities
{
    public class BsonCollectionAttribute: Attribute
    {
        public string CollectionName { get; }

        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
