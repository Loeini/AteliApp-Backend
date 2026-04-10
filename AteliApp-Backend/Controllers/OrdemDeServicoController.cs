using AteliApp.Application.DTOs;
using AteliApp.Application.Services;
using AteliApp.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AteliApp.Controllers;

[ApiController]
[Route("api/OrdemDeServico")]
public class OrdemDeServicoController : ControllerBase
{
    private readonly OrdemDeServicoService _service;

    public OrdemDeServicoController(OrdemDeServicoService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CriarOrdemDeServicoRequest request)
    {
        var osRequest = new CriarOrdemDeServicoDto(
            request.ClienteId,
            request.Titulo,
            request.Descricao,
            request.DataEntrega,
            request.Status,
            request.TipoServico,
            request.Valor,
            request.MedidasId
          );


        await _service.CriarAsync(osRequest);
        return Created();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] AtualizarOrdemDeServicoRequest request)
    {
        var osRequest = new AtualizarOrdemDeServicoDto(
            request.Titulo,
            request.Descricao,
            request.DataEntrega,
            request.Status,
            request.TipoServico,
            request.Valor
          );
        await _service.AtualizarAsync(id, osRequest);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var ordens = await _service.ListarAsync();
        return Ok(ordens);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(Guid id)
    {
        var ordem = await _service.ObterPorIdAsync(id);
        return Ok(ordem);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeletarAsync(id);
        return NoContent();
    }
    
}
