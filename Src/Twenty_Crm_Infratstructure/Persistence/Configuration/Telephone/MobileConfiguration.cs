﻿namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Contact;

public class MobileConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Telephone.Mobile>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Telephone.Mobile> builder)
    {
        
        


        builder.Property(b => b.PhoneNumber).HasMaxLength(30);


        builder.HasOne(b => b.User)
            .WithMany(s => s.Mobiles)
                .HasForeignKey(s => s.UserRef);
        builder.HasOne(b => b.Operator)
            .WithMany(b => b.Mobiles)
                .HasForeignKey(z => z.OperatorRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
