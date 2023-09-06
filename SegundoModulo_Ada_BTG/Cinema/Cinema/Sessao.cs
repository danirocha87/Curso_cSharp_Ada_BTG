using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Sessao
    {
        //propriedade -atributo
        private Filme  Filme { get; set; }

        //propriedade -atributo
        private Sala Sala { get; set; }

        //propriedade -atributo
        private DateTime DataHora { get; set; }

        //construtor da classe, via injeção de dependencia
        public Sessao(Sala sala, DateTime dataHora)
        {
            Sala = sala;
            DataHora = dataHora; 
        }

        public void AddFilme (Filme filme) 
        {
        Filme= filme;
        }

        public override string ToString()
        {
            StringBuilder builder= new StringBuilder();

            builder.AppendLine($"Nome: {Filme.Titulo} - Hora:{DataHora.ToString("HH:mm - dd/MM/yyyy")}");
            builder.AppendLine($"Sala: {Sala.Numero}");

            return builder.ToString();
        }
    }
}
