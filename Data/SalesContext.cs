#region Using

using SalesApp.Interfaces;
using SalesApp.Models;

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

#endregion

namespace SalesApp.Data
{
    class SalesContext : DbContext
    {

        #region DbSets

        /// <summary>DbSet representing the Sales table.</summary>
        public DbSet<Sale> Sales { get; set; }

        /// <summary>DbSet representing the SalesPersons table.</summary>
        public DbSet<SalesPerson> People { get; set; }

        /// <summary>DbSet representing the SalesRegions table.</summary>
        public DbSet<SalesRegion> Regions { get; set; }

        #endregion

        #region OnModelCreating

        /// <summary>
        /// This method is called when the model for the context has been initialised, but before the model has been locked down and used to initialise the context.
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder that defines the model for the context being created.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        #endregion

        #region SaveChanges

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// The number of objects written to the underlying database.
        /// </returns>
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            // Get the state mananger to changed entities.
            var stateManager = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;

            // "Soft" delete entities that implement IActive

            var deletedEntities = stateManager
                .GetObjectStateEntries(EntityState.Deleted)
                .Select(e => e.Entity)
                .OfType<IActive>()
                .ToArray();

            foreach (var deletedEntity in deletedEntities)
            {
                if (deletedEntity == null) continue;
                stateManager.ChangeObjectState(deletedEntity, EntityState.Modified);
                deletedEntity.Active = false;
            }

            // Auditing for newly created entities

            var createdEntities = stateManager
                .GetObjectStateEntries(EntityState.Added)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreatedDate = DateTime.Now;
                createdEntity.CreatedBy = Environment.UserName;
                createdEntity.UpdatedDate = DateTime.Now;
                createdEntity.UpdatedBy = Environment.UserName;
            }

            // Auditing for updated entities

            var updatedEntities = stateManager
                .GetObjectStateEntries(EntityState.Modified)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var updatedEntity in updatedEntities)
            {
                updatedEntity.UpdatedDate = DateTime.Now;
                updatedEntity.UpdatedBy = Environment.UserName;
            }

            // Save change to the database
            return base.SaveChanges();
        }

        #endregion

    }
}
