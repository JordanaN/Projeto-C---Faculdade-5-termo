using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public String NomeMedicamento { get; set; }
        public int QtdadeMin { get; set; }
        public Double Valor { get; set; }
        public int Categoria { get; set; }

        public Produto(int codigo, string nome, int qtdaMin, int categoria, double valor)
        {
            Codigo = codigo;
            NomeMedicamento = nome;
            QtdadeMin = qtdaMin;
            Categoria = categoria;
            Valor = valor;
        }      
    }
}
