namespace Aula13_Sprint4_Uber
{
    public class Conta : Motorista
    {
        private string agencia {get;set;}
        private string conta {get;set;}

        public string Cadastrar(string agencia ,string conta){
            if(this.agencia==agencia && this.conta==conta){
                return "Conta cadastrada";
            }
            return "Digite os valores certos!";
        }
        
        public string Excluir(string agencia ,string conta){
            if(this.agencia==agencia && this.conta==conta){
                return "Conta excluida!";
            }
            return "Digite os valores certos!";
        }
    }
}