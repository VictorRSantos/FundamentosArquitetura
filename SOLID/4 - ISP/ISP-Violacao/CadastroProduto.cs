namespace SOLID.ISP_Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Insert na tabela Produto
        }
        public void EnviarEmail()
        {
            //  Produto não tem e-mail, o que faço agora???
            throw new NotImplementedException(message:"Esse metodo não serve pra nada");
        }

    }
}
