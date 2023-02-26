using System;
using System.Collections.Generic;
using System.Text;

namespace Syscotech
{
    class Book
    {
       

        public Book(int id, string title, string author, int isbn, int copies, string itemType)
        {
           this.Id1 = id;
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
            this.Copies = copies;
            this.ItemType = itemType;
        }

        public int Id1 { get; set; }
        public string Title { get;  }
        public string Author { get;  }
        public int Isbn { get;  }
        public int Copies { get; set; }
        public string ItemType { get;  }

        
        public void CopiesIncrease()
        {
            Copies++;
        }
        public void CopiesDecrease()
        {
            Copies--;
        }
        
    }
}
