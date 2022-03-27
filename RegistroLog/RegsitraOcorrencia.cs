using System;

namespace solid
{
    public class RegsitraOcorrencia
    {
        //injecao de dependencia
        private readonly IRegistro _registro;

        public RegsitraOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }

    public void Registrar(string msg)
    {
        _registro.RegistraInfo($"{msg} : {DateTime.Now}");
    }

    //implementacao

    }

}