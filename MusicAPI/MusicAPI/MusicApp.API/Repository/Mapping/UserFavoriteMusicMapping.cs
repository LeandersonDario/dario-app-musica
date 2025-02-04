﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.API.Repository.Mapping
{
    public class UserFavoriteMusicMapping : IEntityTypeConfiguration<UserFavoriteMusic>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteMusic> builder)
        {
            builder.ToTable("UserFavoriteMusic");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.MusicId);

            builder.HasOne(x => x.Music)
                   .WithOne()
                   .HasForeignKey<UserFavoriteMusic>(x => x.MusicId);
        }
    }
}
