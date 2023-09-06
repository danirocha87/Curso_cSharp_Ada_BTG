using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Filme
    { 
        //propriedades
        public string Titulo { get; set;}
        //propriedades
        public int Ano { get;set;}

        //propriedade
        public int Duracao { get; set;}

        public Filme(string titulo, int ano, int duracao)
        {
            Titulo = titulo;
            Ano = ano;
            Duracao = duracao;
        
        }
    
    }
}
