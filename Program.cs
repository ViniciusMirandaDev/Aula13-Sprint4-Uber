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

             if(user.TokenLogin != "" && user.TokenLogin!= null){
                 System.Console.WriteLine("Acesso liberado! usuário logado");
                 System.Console.WriteLine(user.TokenLogin);
             }else{
                 System.Console.WriteLine("Usuário deslogado");
             }
             
        }
    }
}
