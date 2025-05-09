﻿using LinkDev.Talabat.Core.Domain.Common;
using LinkDev.Talabat.Infrastructure.Persistence._Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Talabat.Infrastructure.Persistence._Data.Configs.Base
{
    [DbContextType(typeof(StoreDbContext))]
    public class BaseEntityConfigurations<TEntity, TKey> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(E => E.Id)
                        .IsRequired()
                        .ValueGeneratedOnAdd();
        }


    }
}
