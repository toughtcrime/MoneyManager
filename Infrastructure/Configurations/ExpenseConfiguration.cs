using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ExpenseConfiguration : IEntityTypeConfiguration<ExpenseItem>
{
    public void Configure(EntityTypeBuilder<ExpenseItem> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Title)
                .HasMaxLength(20)
                .IsRequired();
        
        builder.Property(x => x.Cost)
               .IsRequired();
    }
}