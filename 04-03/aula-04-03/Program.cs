using aula_04_03.entidade;
using aula_04_03.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro nome");
            var nome = (Console.ReadLine());

            Console.WriteLine(" Qual o seu documento RG");
            var documento = (Console.ReadLine());

            Console.WriteLine("Digite o  seu email");
            var email = (Console.ReadLine());

            var pessoa = new Pessoa(documento, nome, email);

            EmailService.EnviarEmail(new Pessoa("00000000000", "jefinho", "jefersonpereira2008@hotmail.com"));
            Console.ReadLine();
        }

    }
    
}
