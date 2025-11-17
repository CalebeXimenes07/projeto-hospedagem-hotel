using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Reserva
    {


        public List<Pessoa> listaHospedes { get; set;}
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            listaHospedes = new List<Pessoa>();
        }

        public void cadastrarHospedesESuite()
        {

int quantidadeHospedes;
string tipoSuite;
int capacidadeSuite;
decimal valorDiaria;

while (true)
            {

Console.WriteLine("Insira a quantidade de hóspedes que serão cadastrados: ");

if (int.TryParse(Console.ReadLine(), out quantidadeHospedes))
                {
                    if (quantidadeHospedes > 0)
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
                
for (int contador = 0; contador < quantidadeHospedes; contador++)

            {
                        
    Console.WriteLine($"Insira o nome do {contador + 1}° hóspede: ");
    
    string entradaNomeHospede = Console.ReadLine();
    
    Console.WriteLine($"Insira o sobrenome do {contador + 1}° hóspede: ");
    
    string entradaSobrenomeHospede = Console.ReadLine();

    Pessoa pessoa = new Pessoa(nome: entradaNomeHospede, sobrenome: entradaSobrenomeHospede);

    this.listaHospedes.Add(pessoa);

            }

while (true)

{
    
Console.WriteLine("\nDigite o tipo de suíte em que você(s) deseja(m) se hospedar:\n1 para Premium\n2 para Confort\n3 para básica\n4 para econômica");

string entradaOpcao = Console.ReadLine();

    if (!string.IsNullOrEmpty(entradaOpcao))
{
             if (entradaOpcao == "1")
        {
            tipoSuite = "Premium";
            capacidadeSuite = 4;
            valorDiaria = 150;
            
            if (capacidadeSuite < quantidadeHospedes)
             {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte! ");
             }

             else

             {
                break;
             }
        }
            else if (entradaOpcao == "2")
        {
            tipoSuite = "Confort";
            capacidadeSuite = 3;
            valorDiaria = 120;
            
            if (capacidadeSuite < quantidadeHospedes)
             {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte! ");
             }

            else
             {
                break;
             }
        }
            else if (entradaOpcao == "3")
        {
            tipoSuite = "Basica";
            capacidadeSuite = 2;
            valorDiaria = 95;

            if (capacidadeSuite < quantidadeHospedes)
             {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte! ");
             }

            else
             {
                break;
             }
        }
            else if (entradaOpcao == "4")
        {
            tipoSuite = "Economica";
            capacidadeSuite = 1;
            valorDiaria = 70;

             if (capacidadeSuite < quantidadeHospedes)
             {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte! ");
             }
             else
                {
             break;
                }
        }
            else
        {
            Console.WriteLine("Insira uma opção válida: ");    
        }

}
}  
            Suite = new Suite(tipoSuite, capacidadeSuite, valorDiaria);
        }



    public int obterQuantidadeHospedes()
        {
       return listaHospedes.Count;
        }

        public decimal calcularValorTotal()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
            
            decimal valorTotalComDesconto = valorTotal - (valorTotal * 0.1M);
            return valorTotalComDesconto;
            
            }
            else
            {

            return valorTotal;
            }
        }
    }
}