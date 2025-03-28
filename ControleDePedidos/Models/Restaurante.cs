namespace ControleDePedidos.Models;

public class Restaurante
{
    public List<Pedido> pedidos = new List<Pedido>();
    public Dictionary<string, Prato> pratos = new Dictionary<string, Prato>();

    public void RegistrarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
        Console.WriteLine("Pedido Adicionado com Sucesso");
    }

    public void RemoverPedido(Pedido pedido)
    {
        if (!pedidos.Contains(pedido))
        {
            Console.WriteLine("Pedido não encontrado");
            return;
        }
        pedidos.Remove(pedido);
        Console.WriteLine("Pedido Removido com Sucesso");
    }

    public static string CalcularTotalPedidos(List<Pedido> pedidos)
    {
        decimal total = pedidos.Sum(p => p.Itens.Sum(prato => prato.Preco));
        return $"Valor total dos pedidos: R$ {total:C}";
    }

    public static string ObterDadosPorCliente(List<Pedido> pedidos, string cliente)
    {
        var pedidosCliente = pedidos.Where(p => p.Cliente == cliente).ToList();
        var resultado = $"Dados do cliente: {cliente}";
        foreach (var pedido in pedidosCliente)
        {
            foreach (var prato in pedido.Itens)
            {
                resultado += $"\nPrato: {prato.Nome} - Preço: {prato.Preco}";
            }
        }

        return resultado;

    }
}
