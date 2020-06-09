namespace Aula13_Sprint4_Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "paulo@gmail.com";
        private string senha = "123456789";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login ,string senha){
            if(this.login==login && this.senha==senha){
                TokenLogin="wqew3qwq3e3weqw3qwe3we3wqeq3we";
                return true;
            }
            return false;
        }

        public void logout(){
            TokenLogin="";
        }


    }
}