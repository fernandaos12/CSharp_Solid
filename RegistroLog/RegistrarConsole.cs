using System;

namespace solid
{
    public class RegistrarConsole : IRegistro
    {
        public void RegistraInfo(string msg)
        {
            Console.WriteLine($"info: {msg}");
        }
    }
}