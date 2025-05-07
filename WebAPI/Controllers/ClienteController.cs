using Application.Services;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    // CREATE
    [HttpPost]
    public IActionResult CrearCliente([FromBody] Cliente cliente)
    {
        _clienteService.AgregarCliente(cliente);
        return CreatedAtAction(nameof(ObtenerClientePorId), new { id = cliente.Id }, cliente);
    }

    // READ (Get by Id)
    [HttpGet("{id}")]
    public IActionResult ObtenerClientePorId(int id)
    {
        var cliente = _clienteService.ObtenerClientePorId(id);
        if (cliente == null)
            return NotFound();

        return Ok(cliente);
    }

    // UPDATE
    [HttpPut("{id}")]
    public IActionResult ActualizarCliente(int id, [FromBody] Cliente cliente)
    {
        var existente = _clienteService.ObtenerClientePorId(id);
        if (existente == null)
            return NotFound();

        _clienteService.ActualizarCliente(existente);
        return NoContent();
    }

    // DELETE
    [HttpDelete("{id}")]
    public IActionResult EliminarCliente(int id)
    {
        var existente = _clienteService.ObtenerClientePorId(id);
        if (existente == null)
            return NotFound();

        _clienteService.EliminarCliente(id);
        return NoContent();
    }
}
