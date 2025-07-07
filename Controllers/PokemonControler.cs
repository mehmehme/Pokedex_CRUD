using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    private readonly PokemonService _service;

    public PokemonController(PokemonService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pokemon>>> Get() => Ok(await _service.Listar());
    //read
    [HttpGet("{id}")]
    public async Task<ActionResult<Pokemon>> Get(string id)
    {
        var poke = await _service.BuscarPorId(id);
        return poke is null ? NotFound() : Ok(poke);
    }
    //create
    [HttpPost]
    public async Task<IActionResult> Post(Pokemon poke)
    {
        await _service.Criar(poke);
        return CreatedAtAction(nameof(Get), new { id = poke.Id }, poke);
    }
    //update
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, Pokemon poke)
    {
        await _service.Atualizar(id, poke);
        return NoContent();
    }
    //delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _service.Deletar(id);
        return NoContent();
    }
}

//dados a inserir
{
  "nome": "Charmander",
  "descricao": "Lagarto de fogo",
  "tipos": ["<id_tipo_fogo>"],
  "habilidades": ["<id_habilidade_chama>"]
}



{
  "nome": "Bulbasaur",
  "descricao": "Planta com semente",
  "tipos": ["<id_tipo_planta>"],
  "habilidades": ["<id_habilidade_overgrow>"]
}



{
  "nome": "Squirtle",
  "descricao": "Tartaruga de água",
  "tipos": ["<id_tipo_agua>"],
  "habilidades": ["<id_habilidade_torrent>"]
}
