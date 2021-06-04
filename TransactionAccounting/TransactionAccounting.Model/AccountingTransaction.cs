using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionAccounting.Model
{
    public class AccountingTransaction
    {
        public Guid? Id { get; set; }
        public AccountingProcess Accountingprocess { get; set; }
        public Accounting Accounting { get; set; }

    }
}
