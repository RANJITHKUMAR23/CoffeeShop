using CoffeeShop.Models.Map;
using CoffeeShop.Models.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models.DatabaseContext
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("CofeeShopContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // List of Entities
        public virtual DbSet<Company> Company { get; set; }




        /// <summary>
        /// On model creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateInitializer());
            //Database.SetInitializer<ApplicationDbContext>(new AlwaysCreateInitializer());
            //Database.SetInitializer<ApplicationDbContext>(new DropCreateIfChangeInitializer());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Entity<ApplicationUser>()
                       .HasMany(m => m.Claims).WithOptional().HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);

            modelBuilder.Configurations.Add(new CompanyMap());

        }


        #region Db Initializer

        public class CreateInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                //context.Seed(context);
                base.Seed(context);
            }
        }

        public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                //context.Seed(context);
                base.Seed(context);
            }
        }
       
        public class AlwaysCreateInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                //context.Seed(context);
                base.Seed(context);
            }
        }

        #endregion


    }



}
