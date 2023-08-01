using System.Security.Principal;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning OOP");

            //Criando instância da conta 1
            Account account1 = new Account();

            //Criando instância da conta 2
            Account account2 = new Account();

            account1.Saldo = 1500;
            account1.Limite = 500;
            account1.Numero = 123;

            account2.Saldo = 3000;
            account2.Limite = 800;
            account2.Numero = 879;

            Console.WriteLine("Olá, Daniela, seu saldo em conta é: " + account1.Saldo);
            Console.WriteLine("Limite de saque: " + account1.Limite);
            Console.WriteLine("O número da conta é " + account1.Numero);

            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("");

            Console.WriteLine("Olá, Maria, seu saldo em conta é: " + account2.Saldo);
            Console.WriteLine("Limite de saque: " + account2.Limite);
            Console.WriteLine("O número da conta é " + account2.Numero);

            
        }
    }
}