namespace Poo
{
  internal abstract class Forma
  {
    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public override string ToString()
    {
      return $"Cor: {Cor}\n" +
             $"Área: {Area}\n" +
             $"Perímetro: {Perimetro}\n";
    }
  }
}