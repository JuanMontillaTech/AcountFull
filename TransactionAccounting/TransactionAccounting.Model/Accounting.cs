using System;
using System.Collections.Generic;
using System.Text;

using TransactionAccounting.Model.Common;

namespace TransactionAccounting.Model
{
   public  class Accounting : BaseModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
