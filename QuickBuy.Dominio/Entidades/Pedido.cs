﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual DateTime DataPrevisaoEntrega { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string EnderecoCompleto { get; set; }
        public virtual int NumeroEndereco { get; set; }
        public virtual int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        public virtual Usuario Usuario { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Erro - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Erro - CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Erro - Não foi informado nenhuma forma de pagamento");
        }
    }
}
