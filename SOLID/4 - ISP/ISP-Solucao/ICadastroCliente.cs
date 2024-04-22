namespace SOLID.ISP_Solucao
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();       
        void EnviarEmail();
    }

}
