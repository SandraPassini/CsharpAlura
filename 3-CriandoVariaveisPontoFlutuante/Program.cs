using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario1;
        salario1 = 3000.10;

        double salario2 = 3000;

        double idade;

        idade = 7 / 5;

        Console.WriteLine("idade: " + idade);

        double idade2;
        //
        idade2 = 7.0 / 5;

        Console.WriteLine("idade2: " + idade2);

        Console.WriteLine("salario1: " + salario1);
        Console.WriteLine("salario2: " + salario2);

        double peso = 4.0;
        int quantidade = 10;
        Console.WriteLine(peso * quantidade);

        double brindes = 15.0;
        int pessoas = 2;
        Console.WriteLine(brindes / pessoas);

        int brindes1 = 15;
        int pessoas1 = 2;
        Console.WriteLine(brindes1 / pessoas1);

        int dia = 4;
        int outroDia = 4 + dia;
        Console.WriteLine(outroDia);

        double preco = 5.0;
        double ingressos = 5.0;
        Console.WriteLine(preco * ingressos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}