namespace Poo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Carro fusca = new Carro("preto", "1300");

      fusca.Acelerar();
      fusca.Acelerar();
      Console.WriteLine($"A velocidade atual é {fusca.ObterVelocidade()}km/h");
      fusca.Acelerar();
      fusca.Desacelerar();
      fusca.Virar("esquerda");
      fusca.Parar();
    }
  }
}