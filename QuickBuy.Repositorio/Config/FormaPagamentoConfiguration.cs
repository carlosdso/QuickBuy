using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Objetodevalor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            // Builder.Haskey
        }
    }
}
