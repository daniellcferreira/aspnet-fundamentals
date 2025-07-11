namespace Poo
{
  public class Animal
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public decimal Peso { get; set; }
    public string Genero { get; set; }

    public void Andar()
    {
      Console.WriteLine($"O cachorro {Nome} está andando.");
    }

    public void Comer(decimal quantidadeComida)
    {
      Peso += quantidadeComida;
    }

    public void Dormir()
    {
      Console.WriteLine($"O cachorro {Nome} está dormindo.");
    }

  }


}