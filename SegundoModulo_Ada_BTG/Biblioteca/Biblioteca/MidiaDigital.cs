using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {

        public int CodigoMidia { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public MidiaDigital(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) : base(titulo, autor, anoPublicacao, numPaginas)
        {

        }
        public string Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;

                return $"Midia digital: {Titulo} escrito por  {Autor} foi disponibilizada em: ({DataEmprestimo.ToShortDateString()})";
            }
            else
            {
                return $"Midia digital: {Titulo}  não  disponível..";
            }
        }

        public string Devolver(DateTime dataDevolucao)
        {
            return $"Midia Digital não tem devolução.";
        }
    }
}