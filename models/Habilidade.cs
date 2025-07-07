public class Habilidade
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
}