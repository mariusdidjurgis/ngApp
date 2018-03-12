using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ngApp.Web.EntityConfigurations.Base;
using ngApp.Web.Models.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.EntityConfigurations.Vehicle
{

    internal class ModelConfiguration : DbEntityConfiguration<Model>
    {
        public override void Configure(EntityTypeBuilder<Model> entity)
        {
            entity.ToTable("models");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired();
            entity.Property(c => c.Color).IsRequired();
            entity.Property(x => x.MakeId).IsRequired();
        }
    }
}
