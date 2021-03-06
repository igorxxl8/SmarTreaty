﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using SmarTreaty.Common.DomainModel;

namespace SmartTreaty.Data.DataAccess.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        private const int MaxLength = 32;

        public RoleConfiguration()
        {
            HasKey(r => r.Id);

            Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(MaxLength)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Name") { IsUnique = true }));

            HasMany(r => r.Users)
                .WithMany(u => u.Roles)
                .Map(ru =>
                {
                    ru.ToTable("RoleUser");
                    ru.MapLeftKey("RoleId");
                    ru.MapRightKey("UserId");
                });
        }
    }
}