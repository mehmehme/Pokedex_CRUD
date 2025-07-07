public class Estatistica
{
    [BsonId, BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string IdPokemon { get; set; }
    public int HP { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public int Velocidade { get; set; }
    public int AtaqueEspecial { get; set; }
    public int DefesaEspecial { get; set; }
}