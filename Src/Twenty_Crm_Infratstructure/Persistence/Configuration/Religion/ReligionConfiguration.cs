﻿namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Religion;

public class ReligionConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Religion.Religion>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Religion.Religion> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);

    }
}
