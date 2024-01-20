using ejercicioclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclases
{
    internal class Ave
    {
        public string? Nombre;

        public string? Color;

        public string? Tamano;

        public string? Familia;

        public string? SexoBiologico;

        public bool? EsVoladora;

        public Ave() 
        {
            EsVoladora = true;   
        }

        public void imprimir()
        {
            Console.WriteLine($"Nombre:   {Nombre} ");
            Console.WriteLine($"Tamaño:  {Tamano}");
            Console.WriteLine($"Familia:  {Familia}");
            Console.WriteLine($"Color:  {Color}");
            Console.WriteLine($"Sexo biologico: {SexoBiologico}");

        }
    }

  
}
