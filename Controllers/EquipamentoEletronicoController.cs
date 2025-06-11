using Invent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Invent.Controllers;

[Controller]
[Route("api/[controller]")]
public class EquipamentoEletronicoController: Controller {
    
    private readonly EquipamentoEletronicoContext _context;
    public EquipamentoEletronicoController(EquipamentoEletronicoContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<List<EquipamentoEletronico>> Get()
    {
        var data = await _context.equipamentoEletronico.ToListAsync();
        return data;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EquipamentoEletronico data)
    {
        _context.equipamentoEletronico.Add(data);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = data.Id }, data);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] EquipamentoEletronico data)
    {
        if (id != data.Id)
        {
            return BadRequest();
        }

        var item = await _context.equipamentoEletronico.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        item.nome = data.nome;
        item.tipo = data.tipo;
        item.qtdeEstoque = data.qtdeEstoque;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
       var data = await _context.equipamentoEletronico.FindAsync(id);
        if (data == null)
        {
            return NotFound();
        }

        _context.equipamentoEletronico.Remove(data);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}