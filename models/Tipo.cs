public class Tipo
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Nome { get; set; }
}
