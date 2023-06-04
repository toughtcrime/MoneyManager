using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Password)
               .HasMaxLength(30)
               .IsRequired();
        
        builder.Property(x => x.Username)
               .HasMaxLength(15)
               .IsRequired();
    }
}