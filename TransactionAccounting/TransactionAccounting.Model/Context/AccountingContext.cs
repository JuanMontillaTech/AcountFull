using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using TransactionAccounting.Model.Common;

namespace TransactionAccounting.Model.Context
{
   public class AccountingContext :DbContext
    {
        public AccountingContext( DbContextOptions<AccountingContext> options) : base(options)
        {

        }
        #region TechnicalFields
     
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            TechnicalFields();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            TechnicalFields();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            TechnicalFields();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void TechnicalFields()
        {
            foreach (EntityEntry item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseModel bm && bm.Id == null)
                {
                    bm.Id = Guid.NewGuid();
                }

            }
        }
        #endregion
        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<AccountingProcess>  AccountingProcesses { get; set; }
        public DbSet<AccountingTransaction> AccountingTransactions { get; set; }

    }
}
