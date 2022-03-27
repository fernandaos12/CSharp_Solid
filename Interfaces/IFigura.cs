namespace CSharp_Solid
{
    public interface IFigura
    {
           string Nome{get; set;}

         void Desenhar();
         void Identificar();

         void Duplicar();
    }
}