namespace Poo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Carro carro1 = new Carro();
      Carro carro2 = new();
      var carro3 = new Carro();

      carro1.cor = "azul";
      carro2.cor = "vermelho";
      carro3.cor = "preto";

      Carro.qtdCarros = 3;
    }
  }
}