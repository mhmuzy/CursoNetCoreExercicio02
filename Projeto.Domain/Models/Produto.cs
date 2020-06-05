using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Models
{
    public class Produto
    {
        //prop + 2x[tab]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }

        #region Categoria Associação 1 p 1

        public Guid CategoriaId { get; set; }

        #endregion

        #region Fornecedor Associação 1 p 1

        public Guid FornecedorId { get; set; }

        #endregion

        //ctor + 2x[tab]
        public Produto()
        {

        }

        //Sobrecarga (overloading) de construtores
        public Produto(Guid id, string nome, decimal preco, int quantidade, DateTime dataCompra, Guid categoriaId, Guid fornecedorId)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            CategoriaId = categoriaId;
            FornecedorId = fornecedorId;
        }
    }
}
