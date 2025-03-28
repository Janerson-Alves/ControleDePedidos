
using ControleDePedidos.Models;

Restaurante restaurante1 = new Restaurante();

Prato prato1 = new Prato { Nome = "Carne Moida", Preco = 50 };
Prato prato2 = new Prato { Nome = "File De Frango", Preco = 30 };
Prato prato3 = new Prato { Nome = "Pastel", Preco = 30 };

Pedido pedido1 = new Pedido { Cliente = "João" };
pedido1.AdicionarPrato(prato1);
pedido1.AdicionarPrato(prato2);
pedido1.AdicionarPrato(prato3);

Pedido pedido2 = new Pedido { Cliente = "Maria" };
pedido2.AdicionarPrato(prato1);

restaurante1.RegistrarPedido(pedido2);


restaurante1.RegistrarPedido(pedido1);
Console.WriteLine(Restaurante.CalcularTotalPedidos(restaurante1.pedidos));
Console.WriteLine(Restaurante.ObterDadosPorCliente(restaurante1.pedidos, "Maria"));
