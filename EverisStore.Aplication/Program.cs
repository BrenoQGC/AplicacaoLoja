using EverisStore.Domain;
using System;

namespace EverisStore.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario
            {
                Id = 1,
                Nome = "Breno",
                Email = "breno@mail.com",
                Senha = "senha",
                Ativo = true
            };

            Console.WriteLine("Hello World!");
        }
    }
}
