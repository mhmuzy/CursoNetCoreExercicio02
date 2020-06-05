using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Projeto.Domain.Models;

namespace Projeto.Domain.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        //construtor -> ctor + 2x[tab]
        public ProdutoValidation()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("Id do Produto Obrigatório.");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Nome do Produto Obrigatório")
                .Length(6, 150).WithMessage("Nome do Produto deve ter de 6 a 150 caracteres.");

            RuleFor(p => p.Preco)
                .NotEmpty().WithMessage("Preço do Produto Obrigatório.");

            RuleFor(p => p.Quantidade)
                .NotEmpty().WithMessage("Quantidade do Produto Obrigatório.");
        }
    }
}
