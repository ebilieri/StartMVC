using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Dev.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DataDbContext dataDbContext) : base(dataDbContext)
        {
        }

        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public async Task<Endereco> ObterEnderecoPorForncedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                 .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
