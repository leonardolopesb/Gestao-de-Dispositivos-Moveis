namespace DesafioPOO.Models;

public class Iphone : Smartphone
{
    // Chamando o construtor da classe base Smartphone
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }

    // Método específico para instalar aplicativos no iPhone
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} no iPhone...");
    }
}