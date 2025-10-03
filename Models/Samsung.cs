namespace DesafioPOO.Models;

public class Samsung : Smartphone
{
    // Chamando o construtor da classe base Smartphone
    public Samsung(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }

    // M�todo espec�fico para instalar aplicativos no Samsung
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} no Samsung...");
    }
}