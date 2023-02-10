using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Core.Domain;

namespace MyProject.Data.Mapping
{
    public class ConnectorMap : IEntityTypeConfiguration<Connector>
    {
        public void Configure(EntityTypeBuilder<Connector> builder)
        {
            builder.ToTable("connector");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(300).IsRequired();

            builder.HasMany(c => c.Triggers)
                .WithOne(t => t.ConnectorEntry)
                .IsRequired()
                .HasForeignKey(t => t.ConnectorEntry_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
