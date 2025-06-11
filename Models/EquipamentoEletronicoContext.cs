using Microsoft.EntityFrameworkCore;

namespace Invent.Models;

public class EquipamentoEletronicoContext : DbContext
{
    public EquipamentoEletronicoContext(DbContextOptions<EquipamentoEletronicoContext> options)
        : base(options)
    {
    }

    public DbSet<EquipamentoEletronico> equipamentoEletronico { get; set; } = null!;
}