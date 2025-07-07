using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

public class MongoDBContext
{
    private readonly IMongoDatabase _db;

    public MongoDBContext(IConfiguration config)
    {
        var client = new MongoClient(config["MongoDB:ConnectionString"]);
        _db = client.GetDatabase(config["MongoDB:Database"]);
    }

    public IMongoCollection<Pokemon> Pokemons => _db.GetCollection<Pokemon>("pokemons");
    public IMongoCollection<Tipo> Tipos => _db.GetCollection<Tipo>("tipos");
    public IMongoCollection<Habilidade> Habilidades => _db.GetCollection<Habilidade>("habilidades");
    public IMongoCollection<Evolucao> Evolucoes => _db.GetCollection<Evolucao>("evolucoes");
    public IMongoCollection<Estatistica> Estatisticas => _db.GetCollection<Estatistica>("estatisticas");
} 
