using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

try
{
    // Cria os modelos de hóspedes
    var hospedes = new List<Pessoa>
    {
        new Pessoa("Hóspede 1"),
        new Pessoa("Hóspede 2")
    };

    // Cria a suíte
    var suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);

    // Cria a reserva
    var reserva = new Reserva(diasReservados: 12);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe os resultados
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
