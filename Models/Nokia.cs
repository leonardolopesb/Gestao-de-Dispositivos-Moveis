namespace DesafioPOO.Models;

public class Nokia : Smartphone
{
    // Chamando o construtor da classe base Smartphone
    public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }

    // Método específico para instalar aplicativos no Nokia
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} no Nokia...");
    }
}