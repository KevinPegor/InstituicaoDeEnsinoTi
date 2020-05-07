using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoDeEnsinoTi
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public string Email { get; set; }

        protected Pessoa(string nome, int codigo, string email)
        {
            Nome = nome;
            Codigo = codigo;
            Email = email;
        }
    }
}
