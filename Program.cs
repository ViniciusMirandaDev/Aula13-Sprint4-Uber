using System;

namespace Aula13_Sprint4_Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user= new Usuario();

             System.Console.WriteLine("Digite seu login: ");
             string login = Console.ReadLine();

             System.Console.WriteLine("Digite sua senha: ");
             string senha = Console.ReadLine();

             user.Login(login, senha);
             user.TokenLogin="Válido";
             if(user.TokenLogin != "" && user.TokenLogin!= null){
                 System.Console.WriteLine("Acesso liberado! usuário logado");
                 System.Console.WriteLine(user.TokenLogin);
             }else{
                 System.Console.WriteLine("Usuário deslogado");
             }
             
             Passageiro paulo = new Passageiro();
             
             System.Console.WriteLine("Você deseja chamar um motorista?");
             paulo.resposta=Console.ReadLine();
             if(paulo.resposta=="sim"){
                 paulo.ProcurarMotorista();
                 System.Console.WriteLine("Procurando motorista");
             }
             Corrida corrida = new Corrida();
             Motorista joao = new Motorista();
            joao.Nome="Paulo";
             System.Console.WriteLine($"Você gostaria de aceitar a corrida ?");
             joao.resposta2=Console.ReadLine();
             if(joao.resposta2=="sim"){
                 joao.aceitarPassageiro("Paulo");
                 System.Console.WriteLine($"A corrida foi iniciada com Paulo");
             }
            Pagamento viagem = new Pagamento();
            Cartao pauloCartao= new Cartao();
            Conta joaoConta = new Conta();
             
             paulo.Pagar("Corrida finalizada");
             joao.ReceberPagamento("Pagamento transferido");

             
             

             


        }
    }
}
