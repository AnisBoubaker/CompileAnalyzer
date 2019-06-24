﻿using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ErrorCodeConfiguration : IEntityTypeConfiguration<ErrorCode>
    {
        public void Configure(EntityTypeBuilder<ErrorCode> builder)
        {
            builder.ToTable("ErrorCode");

            builder.HasKey(x => x.Id);
        }
    }
}