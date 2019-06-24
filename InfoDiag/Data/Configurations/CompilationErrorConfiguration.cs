﻿namespace Data.Configurations
{
    using Entity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal class CompilationErrorConfiguration : IEntityTypeConfiguration<CompilationError>
    {
        public void Configure(EntityTypeBuilder<CompilationError> builder)
        {
            builder.ToTable("CompilationError");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}