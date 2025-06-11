namespace Invent.Models;

public class EquipamentoEletronico
{
    public string? Id { get; init; } = Guid.NewGuid().ToString();
    public string nome { get; set; } = null!;
    public string tipo { get; set; } = null!;
    public int qtdeEstoque { get; set; }
    public DateTime dataInclusao { get; set; } = DateTime.Now; 
}