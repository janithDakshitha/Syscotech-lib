using System;
using System.Collections.Generic;
using System.Text;

namespace Syscotech
{
    class Loan
    {
        public static int loanId = 1;
        public DateTime LoanDate { get;  }
        public DateTime ReturnDate { get; set; }
        public string Name { get;  }
        public int BookId1 { get; }
        public int Renewals1 { get; set; }
        public int MemID1 { get;  }
        public int LoanId { get;  }

        public Loan(int bookId, int memID, string name, DateTime LoanDate, DateTime ReturnDate, int renewals)
        {
            BookId1 = bookId;
            Name = name;
            this.LoanDate = DateTime.Now;
            this.ReturnDate = LoanDate.AddDays(7);
            Renewals1 = renewals;
            MemID1 = memID;
            this.LoanId = loanId++;

        }

        /*public Loan(int loanId)
        {
            this.LoanId = loanId++;
        }*/

        public void RenewIncrease()
        {
            Renewals1++;
        }
        public void ReturnDateIncrease()
        {
            this.ReturnDate = LoanDate.AddDays(14);
        }
    }

}
