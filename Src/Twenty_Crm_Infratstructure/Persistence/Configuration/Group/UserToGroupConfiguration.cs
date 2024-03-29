﻿namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Group;

public class UserToGroupConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Group.UserToGroup>
{
    void IEntityTypeConfiguration<UserToGroup>.Configure(EntityTypeBuilder<UserToGroup> builder)
    {
        
        
        builder.HasKey(z => z.Id);


        builder.HasOne(s => s.User)
            .WithMany(s => s.UserToGroups)
                .HasForeignKey(s => s.UserRef);


        builder.HasOne(s => s.Group)
            .WithMany(s => s.UserToGroups)
                .HasForeignKey(s => s.GropuRef);   
    }
}
