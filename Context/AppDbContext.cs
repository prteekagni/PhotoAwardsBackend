
using System;
using PhotoAwards.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace PhotoAwards.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public AppDbContext() { }

        public DbSet<UsersModel> User { get; set; }
        public DbSet<ContestsModel> Contests { get; set; }
        public DbSet<EntriesModel> Enteries { get; set; }
        public DbSet<VotingsModel> Voting { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserModel>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.PhoneNo).IsUnique();
            });
            //builder.Entity<CategoryModel>().HasData(new CategoryModel{ ID=Guid.NewGuid()},);               
        }


        /// <summary>  
        /// Overriding Save Changes  
        /// </summary>  
        /// <returns></returns>  
        public override int SaveChanges()
        {
            var addedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseModel &&
                                    (x.State == EntityState.Added));
            var updatedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseModel &&
                                    (x.State == EntityState.Modified));
            //Gt user Name from  session or other authentication   
            var userName = Guid.NewGuid();

            foreach (var entity in addedEntityList)
            {
                ((BaseModel)entity.Entity).ID = Guid.NewGuid();
                ((BaseModel)entity.Entity).CreatedOn = DateTime.Now;
                ((BaseModel)entity.Entity).CreatedBy = userName;
            }
            foreach (var entity in updatedEntityList)
            {

                ((BaseModel)entity.Entity).UpdatedOn = DateTime.Now;
                ((BaseModel)entity.Entity).UpdatedBy = userName;
            }
            return base.SaveChanges();
        }
        /// <summary>  
        /// Overriding Save Changes Async  
        /// </summary>  
        /// <returns></returns>  
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var addedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseModel &&
                                    (x.State == EntityState.Added));
            var updatedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is BaseModel &&
                                    (x.State == EntityState.Modified));
            //Gt user Name from  session or other authentication   
            var userName = Guid.NewGuid();

            foreach (var entity in addedEntityList)
            {
                ((BaseModel)entity.Entity).ID = Guid.NewGuid();
                ((BaseModel)entity.Entity).CreatedOn = DateTime.Now;
                ((BaseModel)entity.Entity).CreatedBy = userName;
            }
            foreach (var entity in updatedEntityList)
            {

                ((BaseModel)entity.Entity).UpdatedOn = DateTime.Now;
                ((BaseModel)entity.Entity).UpdatedBy = userName;
            }
            int result = await base.SaveChangesAsync();
            return result; 
        }
        
    }
}