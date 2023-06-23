using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
       // bool grupo = false;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        int idade = 68;
        bool ehIdoso = idade >= 65;

        Console.WriteLine(ehIdoso);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}