using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ExemploExporando.Models
{
    public class Pessoa
    {
 
       private string _nome;
       private int _idade;
       private string _nomeCompleto;
       public string Sobrenome {get; set;}
       public string NomeCompleto => $"{Nome} {Sobrenome}" ;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
           
            set
            {

            if (value == "")
            {
                throw new ArgumentException ("O nome não pode ser vazio");
                
            }

            _nome = value;
            
            }
         }
       
        public int Idade 
        { 
            get => _idade; 
            
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException ("A idade não pode ser menor que 0");
                
                }

                _idade = value;
            }
            
            
        }  
        
   

        public void Apresentar()
        {
            Console.WriteLine($"Nome:{NomeCompleto}, Idade:{Idade}");
        }
    }
}