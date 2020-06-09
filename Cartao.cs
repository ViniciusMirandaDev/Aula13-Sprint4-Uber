namespace Aula13_Sprint4_Uber
{
    public class Cartao : Passageiro
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

       
        public string CadastrarCartao(string numero, string titular, string bandeira, string cvv ){
            if(this.numero==numero && this.titular==titular && this.bandeira==bandeira && this.bandeira==bandeira){
                return "Cartão cadastrado";
            }
            return "Digite os valores certos!";
        }

       public string ExcluirCartao(string numero, string titular, string bandeira, string cvv ){
            if(this.numero==numero && this.titular==titular && this.bandeira==bandeira && this.bandeira==bandeira){
                return "Cartão excluido";
            }
            return "não foi possível excluir o cartão!";
        }
    }
}