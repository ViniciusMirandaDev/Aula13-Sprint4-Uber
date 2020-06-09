namespace Aula13_Sprint4_Uber
{
    public class Corrida
    {
        public string localInicio{get; set;}
        public string localChegada{get; set;}
        public string statusCorrida{get; set;}
        public string motorista{get; set;}
        public string passageiro{get; set;}

        public string Cancelar(){
            return "Sua corrida foi cancelada!";
        }
    }
}