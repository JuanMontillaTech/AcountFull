using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionAccounting.DAL
{
    public interface IService<Obj>
    {
        void Insert(Obj  obj);
        IEnumerable<Obj> GetAll();
        Obj GetById(int Id);
        void Delete(int Id);
        void Update(Obj  obj);
        void Save();

    }
}
