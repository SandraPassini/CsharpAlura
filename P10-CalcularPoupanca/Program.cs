using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 492000.00;
        double fGTS = 150000.00;
        double poupanca = 4000.00;
        double previdencia = 200000.00;
        double aporte = 3000.00;

        // trecho de código omitido

        int mes = 1;

        while (mes <= 12)
        {
            //PLR
            if (mes == 8)
            {
                investimento = investimento + 8000.00;
            }

            investimento = investimento + investimento * 0.005 + aporte;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
            //mes = mes + 1;
           // mes += 1; //Somar
           mes++;
        }

        double valorTotal = investimento + previdencia + fGTS + poupanca;
        Console.WriteLine("Valor total de: " + valorTotal);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}