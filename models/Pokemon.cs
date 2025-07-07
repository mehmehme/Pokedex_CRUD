using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Pokemon
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<string> Tipos { get; set; }
    public List<string> Habilidades { get; set; }
}