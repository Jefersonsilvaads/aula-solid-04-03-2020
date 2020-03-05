using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_04_03.entidade
{
    class Pessoa
    {
       

        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public Pessoa(string documento, string nome, string email)
        {
            Documento = documento ?? throw new Exception("informe o documento");
            Nome = nome ?? throw new Exception("informe o nomew ");
            Email = email ?? throw new Exception("informe o email");
        }

    }
}
