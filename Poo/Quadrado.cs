namespace Poo
{
   internal class Quadrado : Forma
   {

    public double Lado { get; set; }

    public override void CalcularArea()
    {
      Area = Lado * Lado;
    }

    public override void CalcularPerimetro()
    {
      Perimetro = Lado * 4;
    }
   }
}