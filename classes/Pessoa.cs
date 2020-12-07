using System;

namespace AulaPOO_Heranca.classes
{
    public class Pessoa
    {
        public string nome;

        public string DarBoasVidas(string nomeUsuario)
        {
            return $"Bem-Vindo ao nosso sistema - {nomeUsuario}";
        }
    }
}