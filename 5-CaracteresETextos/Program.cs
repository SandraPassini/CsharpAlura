using System;
class Programa
{
    static void Main(string[] args)
    {
        char letra;
        // trecho de código omitido
        letra = (char)(65 + 1); 
        Console.WriteLine(letra);

        letra = (char)90;
        Console.WriteLine(letra);

        letra = 'O';
        Console.WriteLine(letra);

        string primeiraFrase1 = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase1);

        string primeiraFrase2 = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase2 + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = "Cursos disponíveis:    - Go - C# - Python - Java";
        Console.WriteLine(cursos);

        string cursos2 = "Cursos disponíveis: " +
            "- Go " +
            "- C# " +
            "- Python " +
            "- Java";
        Console.WriteLine(cursos2);

        string cursos3 = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos3);

        string saudacao = "Olá, meu nome é ";
        string nome = "Rômulo ";
        string continuacao = "e minha idade é ";
        int idade = 100;
        Console.WriteLine(saudacao + nome + continuacao + idade);


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}