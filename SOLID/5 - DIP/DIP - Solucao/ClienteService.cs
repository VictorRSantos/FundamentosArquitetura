using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(IEmailServices emailServices, IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar(de: "empresa@empresa.com", para: cliente.Email.Endereco, assunto: "Bem Vindo", mensagem: "Parabéns! você está cadastrado");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
