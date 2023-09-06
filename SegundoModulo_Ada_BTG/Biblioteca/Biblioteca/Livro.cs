using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public int CodigoLivro { get; set; }
        public bool Emprestado { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Livro(int codigo, string titulo, string autor, int anoPublicacao, int numPaginas) : base(titulo, autor, anoPublicacao, numPaginas)
        {

        }
        public string Emprestar(DateTime dataEmprestimo)
        {
            if (!Emprestado)
            {
                Emprestado = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(45);

                return $"Livro: {Titulo} emprestado na data: ({DataEmprestimo.ToShortDateString()})" +
                Environment.NewLine + $"Data limite para devolução: ({DataDevolucao.ToShortDateString()}).";
            }
            else
            {
                return $"Livro: {Titulo} em uso, esta emprestado.";
            }
        }

        public string Devolver(DateTime dataDevolucao)
        {
            if (Emprestado)
            {
                Emprestado = false;
                DataDevolucao = dataDevolucao;
                return $"Livro: {Titulo} ,devolvido na data: ({DataDevolucao.ToShortDateString()}).";
            }
            else
                return "Livro não devolvido";

        }
    }
}

