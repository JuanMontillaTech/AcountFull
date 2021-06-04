using System;
using System.Collections.Generic;
using System.Text;

using TransactionAccounting.Model.Context;

namespace TransactionAccounting.DAL
{
   public class UnitofWork : IDisposable
    {
        private bool disposed = false;
        private readonly AccountingContext _context;
        public UnitofWork(AccountingContext context)
        {
            _context = context;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    _context.Dispose();

                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); 

        }
        public void Save()=> _context.SaveChanges();
        

    }
}
