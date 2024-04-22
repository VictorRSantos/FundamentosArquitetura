namespace SOLID.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdionarCliente(cliente);

            EmailService.Enviar(de: "empresa@empresa.com", para: cliente.Email.Endereco, assunto: "Bem Vindo", mensagem: "Parabéns! você está cadastrado");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
