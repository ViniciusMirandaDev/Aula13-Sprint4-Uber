namespace Aula13_Sprint4_Uber
{
    public class Motorista : Usuario
    {
        private string carro {get; set;}
        private string placa {get; set;}

        public string aceitarPassageiro(string Nome){
            return $"Você deseja aceitar o passageiro {Nome}?";
        }
        public bool ReceberPagamento(string statusCorrida){
            if(true){
                System.Console.WriteLine("Corrida concluída, pagamento recebido");
                return true;
            }

            
        }

    }
}