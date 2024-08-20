using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExporando.Models
{
    public class Pessoa
    {
 
       private string _nome;

        public string Nome 
        { 
            get; 
           
            set;
            
         }
        public int Idade { get; set; }  


        public void Apresentar()
        {
            Console.WriteLine($"Nome:{Nome}, Idade:{Idade}");
        }
    }
}