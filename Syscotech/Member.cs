using System;
using System.Collections.Generic;
using System.Text;

namespace Syscotech
{
    class Member
    {
        public Member(string name, int memId, int numberofbookborrow, string subscriptionLevel)
        {
            this.Name = name;
            MemId1 = memId;
            this.Numberofbookborrow = numberofbookborrow;
            this.SubscriptionLevel = subscriptionLevel;
        }

        public string Name { get;  }
        public int MemId1 { get; set; }
        public int Numberofbookborrow { get; set; }
        public string SubscriptionLevel { get;  }

        public void BorrowedIncrease()
        {
            Numberofbookborrow++;
        }
        public void BorrowedDecrease()
        {
            Numberofbookborrow--;
        }
    }
}
