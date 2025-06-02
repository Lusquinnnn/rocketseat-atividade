using System.Reflection.PortableExecutable;

namespace Hello_world;

public class Carro
{
    public string Modelo { get; set; }
    
    public DateOnly LancadoEm { get; set; }

    public Cor Cor { get; set; }

    public Carro(string modelo)
    {
        Modelo = modelo;
    }
    public void nomeDoModelo()
    {
        Console.WriteLine(Modelo);
    }
}
