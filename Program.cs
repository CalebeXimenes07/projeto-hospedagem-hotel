using System.Runtime.InteropServices.Marshalling;
using ProjetoHospedagemHotel.Models;

List<Pessoa> listaHospedes = new List<Pessoa>();

int entradaDiasReservados;

while (true)
{
    
Console.WriteLine("Quantos dias você pretende ficar hospedado? ");


if (int.TryParse(Console.ReadLine(), out entradaDiasReservados))
                {
                    if (entradaDiasReservados > 0)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("A quantidade inserida é inválida! Deve ser maior que 0.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números.");
                }

            }

Reserva reserva = new Reserva(entradaDiasReservados);

reserva.obterQuantidadeHospedes();

reserva.cadastrarHospedesESuite();

Console.WriteLine("\nNome completo das pessoas hospedadas: ");

foreach (Pessoa pessoasHospedadas in reserva.listaHospedes)
{
    Console.WriteLine(pessoasHospedadas.nomeCompleto);
}

Console.WriteLine($"\nTipo de suite: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Capacidade da suite: {reserva.Suite.CapacidadeSuite}");
Console.WriteLine($"Valor da diária da suite:R${reserva.Suite.ValorDiaria}");
Console.WriteLine($"Quantidade de dias hospedados: {reserva.DiasReservados}");
Console.WriteLine($"Valor total da hospedagem: R${reserva.calcularValorTotal()}");


