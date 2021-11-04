﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverisStore.Domain
{
    public class Produto : EntidadeBase
    {
        public Produto(int id, string nome, string descricao, decimal valor, int quantidadeEstroque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstroque;

            Ativar();
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int QuantidadeEstoque { get; private set; } = 0;
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void DebitaEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            QuantidadeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }
        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }
    }
}