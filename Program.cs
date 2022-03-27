using System;
using CSharp_Solid;

namespace solid
{
    class Program
    {
        static void Main(string[] args)
        {
                // criando log no console e no arquivo txt , descomentar para usar
            /* var RegistraLogConsole = new RegsitraOcorrencia(new RegistrarConsole());
            RegistraLogConsole.Registrar("Registro Console");

            var RegistraLogArquivo = new RegsitraOcorrencia(new RegistrarArquivo(@"D:\workspace\solid\log\log.txt"));
            RegistraLogArquivo.Registrar("Registro Arquivo");
 */
        // Aplicacao de interfaces vs classes abstratas com SOLID

        var quadrado = new Quadrado("Quadrado");
        quadrado.Desenhar();
        quadrado.Identificar();

        var triangulo = new Triangulo("Triangulo");
        triangulo.Desenhar();
        triangulo.Identificar();

            Console.ReadLine();
        }
    }
}


