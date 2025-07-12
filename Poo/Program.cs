namespace Poo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Carro fusca = new Carro("preto", "1300");

      // fusca.Acelerar();
      // fusca.Acelerar();
      // Console.WriteLine($"A velocidade atual é {fusca.ObterVelocidade()}km/h");
      // fusca.Acelerar();
      // fusca.Desacelerar();
      // fusca.Virar("esquerda");
      // fusca.Parar();

      // Gato gato1 = new Gato();

      // gato1.Nome = "Garfield";
      // gato1.Andar();
      // gato1.Comer(0.5m);
      // gato1.Dormir();
      // gato1.Miar();

      // Cachorro cachorro1 = new Cachorro();

      // cachorro1.Nome = "Rex";
      // cachorro1.Andar();
      // cachorro1.Comer(0.5m);
      // cachorro1.Dormir();
      // cachorro1.Latir();

      Quadrado quadrado = new Quadrado();

      quadrado.Lado = 5;
      
      quadrado.CalcularArea();
      quadrado.CalcularPerimetro();

      Console.WriteLine(quadrado.ToString());
    }
  }
}