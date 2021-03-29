using static System.Console;
using System;

class SwitchPedagio
{
    static void Main(string[] args)
    {
        var carro = new Carro() { Passageiros = 6 };
        var caminhao = new Caminhao() { Eixos = 5 };

        WriteLine("Cálculo do pedágio");
        WriteLine($"Pedágio: carro com {carro.Passageiros} passageiros é {CalcularPedagio(carro):n2}");
        WriteLine($"Pedágio: caminhão com {caminhao.Eixos} eixos é {CalcularPedagio(caminhao):n2}");

        ReadLine();
    }

    public static decimal CalcularPedagio(object veiculo) => veiculo switch
    {
        Carro { Passageiros: 0 } => 2.00m + 0.50m,
        Carro { Passageiros: 1 } => 2.00m,
        Carro { Passageiros: 2 } => 2.00m - 0.50m,
        Carro c => 3.00m,

        Caminhao { Eixos: 2 } => 3.50m + 1.00m,
        Caminhao { Eixos: 5 } => 3.50m,
        Caminhao { Eixos: 7 } => 3.50m + 0.50m,
        Caminhao t => 4.50m,

        _ => throw new NotImplementedException(nameof(veiculo)),
    };
}

public class Carro
{
    public int Passageiros { get; set; }
}
public class Caminhao
{
    public int Eixos { get; set; }
}
