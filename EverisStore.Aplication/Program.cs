using EverisStore.Domain;
using System;

namespace EverisStore.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Breno", "breno@mail.com", "123");

            var verificaAtivo = usuario.RetornaAtivo();

            usuario.Desativar();
            usuario.Desativar(1);

            var verificaAtivo2 = usuario.RetornaAtivo();

            usuario.Ativar();
            var verificaAtivo3 = usuario.RetornaAtivo();

            Produto produto = new Produto(1, "Mesa", "Mesa escritorio MDF", 200.00M, 5);

            produto.ReporEstoque(15);
           
            var possuiEstoque = produto.PossuiEstoque(10);
            if (possuiEstoque)
                produto.DebitaEstoque(10);

        }
    }
}
