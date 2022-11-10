using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoAndre = new ContaCorrente();
            contaDoAndre.titular = "André Silva";
            contaDoAndre.numeroAgencia = 15;
            contaDoAndre.conta = "1010-X";
            contaDoAndre.saldo = 100;

            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "Maria Souza";
            contaDaMaria.numeroAgencia = 17;
            contaDaMaria.conta = "1010-5";
            contaDaMaria.saldo = 350;

            Console.WriteLine("Saldo da Conta da Maria =" + contaDaMaria.saldo);

            contaDoAndre.Transferir(500, contaDaMaria);

            Console.WriteLine("Saldo da Conta da André =" + contaDoAndre.saldo);
            Console.WriteLine("Saldo da Conta da Maria =" + contaDaMaria.saldo);
        }
    }
}
