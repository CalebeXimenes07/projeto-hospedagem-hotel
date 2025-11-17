using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Suite
    {

        public string TipoSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiaria { get; set; }
        
        public Suite(string tipoSuite, int capacidadeSuite, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            CapacidadeSuite = capacidadeSuite;
            ValorDiaria = valorDiaria;
        }




    }
}