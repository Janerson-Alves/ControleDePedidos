namespace ControleDePedidos.Models;
#nullable disable
public class Pedido
{
    public string Cliente { get; set; }
    public List<Prato> Itens { get; set; } = new List<Prato>();

    public void AdicionarPrato(Prato prato)
    {
        Itens.Add(prato);
    }


}
