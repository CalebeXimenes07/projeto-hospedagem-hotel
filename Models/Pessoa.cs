using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Pessoa
    {
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        
        public Pessoa (string nome, string sobrenome)
        {

        Nome = nome;
        Sobrenome = sobrenome;
        
        }

        
        public string nomeCompleto => $"{Nome} {Sobrenome}";
    }
}