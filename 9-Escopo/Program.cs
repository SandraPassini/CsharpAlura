using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        //Quando se tem apenas uma linha de tarefa nao é necessario chaves. Caso ao contrario precisa.
    //    {
            Console.WriteLine("Não pode entrar!");
        //   }

        //bool foiPromovido = true;
        //if (foiPromovido)
        //{
        //    double salario = 4200.0;
        //}
        //else
        //{
        //    double salario = 3800.0;
        //}
        //Console.WriteLine(salario);
   // }

    Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}