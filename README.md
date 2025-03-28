# Controle de Pedidos 🍽️

## 📌 Sobre o Projeto
Este projeto é um sistema simples para controle de pedidos em um restaurante. Ele permite cadastrar pratos, adicionar pedidos para clientes e calcular o valor total dos pedidos utilizando listas e dicionários em C#.

## 🛠️ Funcionalidades
- 📋 **Cadastro de Pratos**: Criação de pratos com nome e preço.
- 🛒 **Gerenciamento de Pedidos**:
  - Adicionar pratos a um pedido
  - Remover pratos de um pedido
  - Listar pedidos por cliente
- 🍽️ **Gerenciamento de Restaurante**:
  - Controlar todos os pedidos do restaurante
  - Registrar pedidos de clientes
  - Listar pratos disponíveis
- 💰 **Cálculo do Total de Pedidos**: Soma o valor de todos os pedidos registrados.
- 🔍 **Consulta de Pedidos por Cliente**: Obtém os detalhes dos pedidos de um cliente específico.

## 🚀 Tecnologias Utilizadas
- C#
- .NET
- LINQ (para cálculos e manipulação de listas)

## 📂 Estrutura do Projeto
```
📁 ControleDePedidos
├── 📁 Models
│   ├── Pedido.cs
│   ├── Prato.cs
│   ├── Restaurante.cs
├── Program.cs
├── README.md
```

## 📌 Como Executar o Projeto
### 🔹 1. Clonar o repositório
```bash
git clone https://github.com/seu-usuario/ControleDePedidos.git
cd ControleDePedidos
```
### 🔹 2. Compilar e executar
```bash
dotnet run
```

## 📜 Exemplo de Uso
```csharp
using ControleDePedidos.Models;

Restaurante restaurante1 = new Restaurante();

// Criando pratos
Prato prato1 = new Prato { Nome = "Carne Moída", Preco = 50 };
Prato prato2 = new Prato { Nome = "Filé de Frango", Preco = 30 };
Prato prato3 = new Prato { Nome = "Pastel", Preco = 30 };

// Criando pedidos
Pedido pedido1 = new Pedido { Cliente = "João" };
pedido1.AdicionarPrato(prato1);
pedido1.AdicionarPrato(prato2);
pedido1.AdicionarPrato(prato3);

Pedido pedido2 = new Pedido { Cliente = "Maria" };
pedido2.AdicionarPrato(prato1);

// Registrando pedidos no restaurante
restaurante1.RegistrarPedido(pedido2);
restaurante1.RegistrarPedido(pedido1);

// Calculando total dos pedidos
Console.WriteLine(Restaurante.CalcularTotalPedidos(restaurante1.pedidos));

// Obtendo pedidos de um cliente específico
Console.WriteLine(Restaurante.ObterDadosPorCliente(restaurante1.pedidos, "Maria"));
```

## 📝 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para modificá-lo e usá-lo como desejar.

---

Feito com ❤️ para treinar C# e manipulação de listas e dicionários! 🚀

