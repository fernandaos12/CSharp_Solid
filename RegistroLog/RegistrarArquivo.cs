using System;
using System.IO;

namespace solid
{
    public class RegistrarArquivo : IRegistro
    {
        private readonly string _caminhoarquivo;
        public RegistrarArquivo(string path)
        {
            _caminhoarquivo = path;
        }


        public void RegistraInfo(string msg)
        {
            Log(msg);
        }

        private void Log(string msg)
        {
            using(var streamWriter = new StreamWriter(_caminhoarquivo, true))
            {
                streamWriter.WriteLine(msg);
            }
        }
    }
}