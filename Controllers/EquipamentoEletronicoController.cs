using System;
using Microsoft.AspNetCore.Mvc;
using Invent.Services;
using Invent.Models;

namespace Invent.Controllers;

[Controller]
[Route("api/[controller]")]
public class EquipamentoEletronicoController: Controller {
    
    private readonly EquipamentoEletronicoService _equipamentoEletronicoService;
    public EquipamentoEletronicoController(EquipamentoEletronicoService equipamentoEletronicoService) {
        _equipamentoEletronicoService = equipamentoEletronicoService;
    }

    [HttpGet]
    public async Task<List<EquipamentoEletronico>> Get()
    {
        return await _equipamentoEletronicoService.GetAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EquipamentoEletronico equipamentoEletronico)
    {
        await _equipamentoEletronicoService.CreateAsync(equipamentoEletronico);
        return CreatedAtAction(nameof(Get), new { id = equipamentoEletronico.Id }, equipamentoEletronico);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] string movieId)
    {
        await _equipamentoEletronicoService.UpdateAsync(id, movieId);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _equipamentoEletronicoService.DeleteAsync(id);
        return NoContent();
    }
}