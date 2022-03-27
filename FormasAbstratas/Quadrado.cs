using System;

namespace CSharp_Solid
{
    public class Quadrado : Figura
    {
        public Quadrado(string nome) : base(nome)
        {
      
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando..{Nome}");
        }
           public override void Identificar()
        {
            Console.WriteLine($"Eu sou o ..{Nome}");
        }
    }
}