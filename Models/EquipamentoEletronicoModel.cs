namespace Invent.Models;

public class EquipamentoEletronico
{
    public string? Id { get; set; }
    public string nome { get; set; } = null!;

    public string tipo { get; set; } = null!;
    public int qtdeEstoque { get; set; }
    
}