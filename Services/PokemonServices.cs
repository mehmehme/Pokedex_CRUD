public class PokemonService
{
    private readonly IMongoCollection<Pokemon> _pokemons;

    public PokemonService(MongoDBContext context)
    {
        _pokemons = context.Pokemons;
    }

    public async Task<List<Pokemon>> Listar() => await _pokemons.Find(_ => true).ToListAsync();

    public async Task<Pokemon> BuscarPorId(string id) => await _pokemons.Find(p => p.Id == id).FirstOrDefaultAsync();

    public async Task Criar(Pokemon poke) => await _pokemons.InsertOneAsync(poke);

    public async Task Atualizar(string id, Pokemon poke) => await _pokemons.ReplaceOneAsync(p => p.Id == id, poke);

    public async Task Deletar(string id) => await _pokemons.DeleteOneAsync(p => p.Id == id);
}
