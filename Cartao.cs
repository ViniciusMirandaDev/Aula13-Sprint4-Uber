namespace Aula13_Sprint4_Uber
{
    public class Cartao : Passageiro
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

        public string CadastrarCartao(){
            return "Seu cartão foi cadastrado!";
        }

        public string ExcluirCartao(){
            return "Seu cartão foi excluido!";
        }
    }
}