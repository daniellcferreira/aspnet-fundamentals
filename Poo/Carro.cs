namespace Poo
{
  internal class Carro
  {
    // Propriedades
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Velocidade { get; set; }

    // Atributo estatico
    public static int qtdCarros;

    public Carro(string cor, string modelo)
    {
      Cor = cor;
      Modelo = modelo;
    }

    // Método de instância
    public void Acelerar()
    {
      Console.WriteLine("Carro acelerando...");
      Velocidade += 1;
    }

    public void Desacelerar()
    {
      Console.WriteLine("Carro desacelerando...");
      Velocidade -= 1;
    }

    public int ObterVelocidade()
    {
      return Velocidade;
    }

    public void Virar(string direcao)
    {
      Console.WriteLine($"Carro virando para {direcao}...");
    }

    public void Parar()
    {
      while (Velocidade > 0)
      {
        Desacelerar();
      }

      Console.WriteLine("Carro parado");
    }


  }
}