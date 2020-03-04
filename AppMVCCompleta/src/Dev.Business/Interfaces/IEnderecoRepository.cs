using Dev.Business.Models;
using System;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorForncedor(Guid fornecedorId);
        Task AtualizarEndereco(Endereco endereco);
    }
}
