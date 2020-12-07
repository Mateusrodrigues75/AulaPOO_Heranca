namespace AulaPOO_Heranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string incricaoEstadal;

        public bool ValidarCNPJ(string cnpj)
        {
            if (cnpj != "")
            {
                return true;
            }
            return false;
        }
    }
}