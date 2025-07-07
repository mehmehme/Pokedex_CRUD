public class Evolucao
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string IdPokemonBase { get; set; }
    public string IdPokemonEvoluido { get; set; }
    public int? Nivel { get; set; }
    public string Item { get; set; }
    public string Condicao { get; set; }
}