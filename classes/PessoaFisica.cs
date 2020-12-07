namespace AulaPOO_Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;


        public bool ValidarCPF(string documento){
            if (documento != "")
            {
                System.Console.WriteLine("CPF Válido");
                return true;
            }

            return false;
        }
    }
}