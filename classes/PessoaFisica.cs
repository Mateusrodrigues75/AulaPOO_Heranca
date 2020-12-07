namespace AulaPOO_Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;


        public bool ValidarCPF(string cpf){
            if (cpf != "")
            {
                return true;
            }

            return false;
        }
    }
}