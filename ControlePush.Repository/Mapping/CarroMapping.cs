using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ControlePush.Domain.Carro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePush.Domain.Account;

namespace ControlePush.Repository.Mapping
{
    public class CarroMapping : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Carros");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Placa).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Modelo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cor).IsRequired().HasMaxLength(50);
        }
    }
}
