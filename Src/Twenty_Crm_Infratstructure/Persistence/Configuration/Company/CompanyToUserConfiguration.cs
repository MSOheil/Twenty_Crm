﻿namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Company;

public class CompanyToUserConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Company.CompanyToUser>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Company.CompanyToUser> builder)
    {
        
        


        //builder.HasOne(z => z.User)
        //    .WithMany(z => z.CompanyToUsers)
        //    .HasForeignKey(z => z.UserRef).IsRequired(true);


        builder.HasOne(z => z.Company)
            .WithMany(b => b.CompanyToUser)
                .HasForeignKey(b => b.CompanyRef).IsRequired(true);
    }
}
