using AteliApp.Application.DTOs;
using AteliApp.Application.Services;
using AteliApp.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AteliApp.Controllers;

[ApiController]
[Route("api/medidas")]
public class MedidasController : ControllerBase
{
    private readonly MedidasService _service;

    public MedidasController(MedidasService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CriarMedidasRequest request)
    {

        var medidas = new CriarMedidasDto(
                request.IdCliente,
                request.Altura,
                request.Busto,
                request.Cintura,
                request.Quadril,
                request.Ombro,
                request.Outros,
                request.Observacao
            );

        await _service.CriarAsync(medidas);
        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] AtualizarMedidasRequest request)
    {
        var medidas = new AtualizarMedidasDto(
                request.Altura,
                request.Busto,
                request.Cintura,
                request.Quadril,
                request.Ombro,
                request.Outros,
                request.Observacao
            );
        await _service.AtualizarAsync(id, medidas);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var medidas = await _service.ListarAsync();
        return Ok(medidas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(Guid id)
    {
        var medidas = await _service.ObterPorIdAsync(id);
        return Ok(medidas);
    }
}