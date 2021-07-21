using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id)
                .HasName("PK_CUSTOMER_ID");

            builder.Property(c => c.Id).ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(c => c.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(c => c.PurchasesProduct)
                .HasColumnName("PURCHASED_PRODUCT")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder.Property(c => c.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(c => c.CreateDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(c => c.ModifiedDate)
                .HasColumnName("MODIFIED_DATE")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(c => c.IsActive)
                .HasColumnName("IS_ACTIVE")
                .HasColumnType("BIT")
                .IsRequired();

        }
    }
}