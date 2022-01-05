using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCTest
{
    class Cliente
    {
        public string Nome;
        public string Endereco;
        public bool PessoaFisica;

        public Cliente(string nome, string endereco, bool pessoaFisica)
        {
            Nome = nome;
            Endereco = endereco;
            PessoaFisica = pessoaFisica;
        }

        public override string ToString()
        {
            return "Nome: " + Nome;
        }
    }
}
