using AspNetExercise1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetExercise1.Infrastructure.Persistence.Configurations;

public class RequestInfoConfiguration : IEntityTypeConfiguration<RequestInfo>
{
    public void Configure(EntityTypeBuilder<RequestInfo> builder)
    {
        builder.ToTable("RequestInfos");
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id).UseIdentityColumn();
        builder.Property(r => r.HttpMethod).IsRequired();
        builder.Property(r => r.UserAgent).IsRequired();
    }
}
