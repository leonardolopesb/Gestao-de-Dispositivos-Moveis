namespace DesafioPOO.Models;

// Classe abstrata para representar um smartphone genérico, não será chamada diretamente pois serve apenas de modelo para outras classes
public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string Imei { get; set; }
    public int Memoria { get; set; }

    // Construtor geral para inicializar as propriedades do smartphone
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;
    }

    // Métodos comuns a todos os smartphones
    public void Ligar()
    {
        Console.WriteLine("Ligando o aparelho...");
    }

    public void Desligar()
    {
        Console.WriteLine("Desligando o aparelho...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public void EnviarMensagem(string numeroDestino, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para {numeroDestino}: {mensagem}");
    }

    public void VerificarMemoria()
    {
        Console.WriteLine($"Memória total de armazenamento: {Memoria}GB");
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Informações do aparelho:\n- Número: {Numero}\n- Modelo: {Modelo}\n- IMEI: {Imei}\n- Memória: {Memoria}GB");
    }

    // Métodos abstratos que devem ser implementados nas classes derivadas
    public abstract void InstalarAplicativo(string nomeAplicativo);
}