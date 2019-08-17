using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public virtual int Id { get; set; }
        public virtual int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual int Quantidade { get; set; }
        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado qual a referência do produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informado");
        }
    }
}