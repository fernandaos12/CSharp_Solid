using System;

namespace solid
{
    class Program
    {
        static void Main(string[] args)
        {

            var RegistraLogConsole = new RegsitraOcorrencia(new RegistrarConsole());
            RegistraLogConsole.Registrar("Registro Console");

            var RegistraLogArquivo = new RegsitraOcorrencia(new RegistrarArquivo(@"D:\workspace\solid\log\log.txt"));
            RegistraLogArquivo.Registrar("Registro Arquivo");

            Console.ReadLine();
        }
    }
}


