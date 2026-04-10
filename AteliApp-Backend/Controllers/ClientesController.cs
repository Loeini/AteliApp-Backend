using AteliApp.Application.DTOs;
using AteliApp.Application.Services;
using AteliApp.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AteliApp.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    private readonly ClienteService _service;

    public ClientesController(ClienteService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CriarClienteRequest request)
    {

        var cliente = new CriarClienteDto(
                request.Cpf,
                request.Nome,
                request.Telefone,
                request.Email,
                request.Endereco
            );

        await _service.CriarAsync(cliente);
        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] AtualizarClienteRequest request)
    {
        var cliente = new AtualizarClienteDto(
                request.Cpf,
                request.Nome,
                request.Telefone,
                request.Email,
                request.Endereco
            );
        await _service.AtualizarAsync(id, cliente);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var clientes = await _service.ListarAsync();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(Guid id)
    {
        var cliente = await _service.ObterPorIdAsync(id);
        return Ok(cliente);
    }
}