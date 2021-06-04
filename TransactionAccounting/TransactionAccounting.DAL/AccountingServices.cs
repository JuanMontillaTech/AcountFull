using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransactionAccounting.Model;
using TransactionAccounting.Model.Context;

namespace TransactionAccounting.DAL
{
    public class AccountingServices : UnitofWork,IService<Accounting>
    {
        private readonly AccountingContext _Context;
     
        public AccountingServices(AccountingContext context) : base(context)
        {
            _Context = context;
        }
        public void Delete(int Id) => _Context.Accountings.Remove(_Context.Accountings.Find(Id));
        public IEnumerable<Accounting> GetAll() => _Context.Accountings.ToList();     
        public Accounting GetById(int Id) => _Context.Accountings.Find(Id);
        public void Insert(Accounting obj) => _Context.Accountings.Add(obj);     
        public void Update(Accounting obj) => _Context.Entry(obj).State = EntityState.Modified;  
      
    }
}
