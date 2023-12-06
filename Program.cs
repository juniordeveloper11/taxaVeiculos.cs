using System;

class Veiculo

{
    static void Main()
    {

        Console.Write("Digite o valor do Carro?");
        double  valorCarro =
            Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite taxa de juros anual(%):");
        double taxaJurosAnual =
            Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite numero de meses do financiamento:");
        int numeroMeses = Convert.ToInt32(Console.ReadLine());
        // CALCULAR TAXA JUROS MENSAL 
        double taxaJurosMensal = taxaJurosAnual / 100 / 12;
        //CALCULAR A PARCELA MENSAL USANDO A FORMULA DE AMORTIZAÇÃO

        double parcelaMensal = (valorCarro * taxaJurosMensal) / (1 -
            Math.Pow(1 + taxaJurosAnual, -numeroMeses));
        //EXIBIR O RESULTADO

        Console.WriteLine($"\nvalor da parcela mensal:{parcelaMensal:C}");

        Console.ReadLine();//PARA MANTER A JANELA ABERTA

    }












}



   
    

  

    
    







