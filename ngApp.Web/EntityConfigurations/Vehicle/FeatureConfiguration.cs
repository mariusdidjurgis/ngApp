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

    internal class FeatureConfiguration : DbEntityConfiguration<Feature>
    {
        public override void Configure(EntityTypeBuilder<Feature> entity)
        {
            entity.ToTable("features");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired();
            entity.Property(c => c.Code);
            entity.Ignore(x => x.Price);
            entity.Ignore(x => x.Active);
        }
    }
}
