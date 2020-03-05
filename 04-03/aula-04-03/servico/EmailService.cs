using aula_04_03.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_04_03.servico
{
     internal class EmailService
    {
        public static void EnviarEmail(Pessoa pessoa)
           => Console.WriteLine($"Para: {pessoa.Email}; Mensagem: {pessoa.Nome}");
    }
}
