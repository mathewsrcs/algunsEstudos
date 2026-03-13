Console.WriteLine("### Classes e métodos! ###");

Carro c1 = new("Sedan", "Chvrolet", "Onix", 2016, 110);
Console.WriteLine($"{c1.Modelo}, {c1.Montadora}, {c1.Marca}, {c1.Ano}, {c1.Potencia}");
c1.Acelerar();

Console.WriteLine("-------------------------------------------");

Carro c2 = new("SUV", "Ford", "EcoSport", 2018, 120);
Console.WriteLine($"{c2.Modelo}, {c2.Montadora}, {c2.Marca}, {c2.Ano}, {c2.Potencia}");
c2.Acelerar();
Console.WriteLine($"Potência antes: {c2.Potencia}");
int novaPotencia = c2.AumentarPotencia(c2.Potencia);
Console.WriteLine($"Retorno do método: {novaPotencia}");
Console.WriteLine($"Potência de c2 após a chamada: {c2.Potencia}");

Console.WriteLine("-------------------------------------------");

Carro c3 = new Carro("Hatch", "Renault");
Console.WriteLine($"{c3.Modelo}, {c3.Montadora}");
Console.ReadKey();

public class Carro
{
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public Carro(string modelo, string montadora, string marca, int ano, int potencia) : this(modelo, montadora)
    {
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }
    public string? Modelo { get; set; }
    public string? Montadora { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando meu {Marca}...");
    }
    public double VelocidadeMaxima(int potencia)
    {
        double velocidadeMaxima  = potencia * 1.75;
        return velocidadeMaxima;
    }
    public int AumentarPotencia (int potencia)
    {
        return potencia + 3;
    }
    public int AumentarPotencia (int potencia)
    {
        return potencia + 5; // terminar esse trem em casa
    }
}
