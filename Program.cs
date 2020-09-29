using System;

namespace BancoTriplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Banco Tripo - Seu APP de 3 bancos em 1 só!");
            Console.WriteLine("############################################################");
            Console.WriteLine();
            Console.WriteLine();

            Cliente objNovoCliente = new Cliente();

            objNovoCliente.nome = "Maitê";
            objNovoCliente.cpf = 12345678900;

            Console.WriteLine("NovO(a) cliente cadastrada com sucesso: "+objNovoCliente.nome);
            Console.WriteLine("CPF: " + objNovoCliente.cpf);

            Console.WriteLine("Seria necessário mais tempo para desenvolver todos os requisitos desse software... versão de testes em desenvolvimento. Em breve novidades.");


        }
    }
}
