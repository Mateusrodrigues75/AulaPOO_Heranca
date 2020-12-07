namespace AulaPOO_Heranca.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string incricaoEstadal;

        public bool ValidarCNPJ(string documento)
        {
            if (documento != "")
            {
                System.Console.WriteLine("CNPJ Válido");

                return true;
            }
            return false;
        }
    }
}