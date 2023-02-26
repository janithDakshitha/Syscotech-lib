using System;

namespace Syscotech
{
    class Program
    {
        private const int view_all_books = 1;
        private const int view_all_members = 2;
        private const int view_all_loans = 3;
        private const int borrow_book = 4;
        private const int renew_loan = 5;
        private const int return_book = 6;
        private const int exit = 7;
        public static Library library = new Library();

        static void Main(string[] args)
        {
            
            Displaymenu();
           int choice= Selectmenu();
            while (choice != exit)
            {
                switch (choice)
                {
                    case 1:
                        ViewAllBooks();
                        break;
                    case 2:
                        ViewAllMembers();
                        break;
                    case 3:
                        ViewAllLoans();
                        break;
                    case 4:
                        BorrowBook();
                        break;
                    case 5:
                        RenewLoan();
                        break;
                    case 6:
                        ReturnBook();
                        break;
                    default:
                        Console.WriteLine("Please enter number between 1-7");
                        break;
                }
                Displaymenu();
                choice = Selectmenu();
            }
        }
       
        public static void Displaymenu() {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("      SYSCOTECH      ");
            Console.WriteLine("=======================");
            Console.WriteLine(view_all_books + ")View all books");
            Console.WriteLine(view_all_members +")View all members");
            Console.WriteLine(view_all_loans+")View all loans");
            Console.WriteLine(borrow_book+")Borrow book");
            Console.WriteLine(renew_loan + ")Renew loan");
            Console.WriteLine(return_book+")Return book");
            
            Console.WriteLine(exit+")Exit");
            Console.WriteLine();
            Console.WriteLine("=======================");


        }
        public static int Selectmenu()
        {
            try
            {
                Console.Write("Option: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static void ViewAllBooks()
        {
            Console.WriteLine("\t{0, -4} {1, -20} {2, -20} {3, -10} {4,-20} {5,-4} ", "BookId", "Title", "Author", "ISBN", "Copies", "Item Type");
            library.DisplayBooks();



        }
    
        public static void ViewAllMembers()
        {
            Console.WriteLine("\t{0, -4} {1, 15} {2, -20} {3, -10} ", "Name", "MemberID", "Subscription Level", "Number of books borrowed");
            library.DisplayMembers();
        }
        public static void ViewAllLoans()
        {
            Console.WriteLine("\t{0, -4} {1, 10} {2, 16} {3, 26} {4,24} {5,10}{6,12}", "BookId", "Borrower", "Loan Date", "Due Date", "Renawals","MEMBER iD","LoanID");
            library.DisplayLoans();
        }
        public static void BorrowBook()
        {
            
            ViewAllBooks();
            Console.WriteLine();
            ViewAllMembers();
            

            
            library.BookBorrow();

        }
        public static void RenewLoan()
        {
            Console.WriteLine("\t{0, -4} {1, 10} {2, 16} {3, 26} {4,24} {5,10}{6,12}", "BookId", "Borrower", "Loan Date", "Due Date", "Renawals", "MEMBER iD", "LoanID");
            library.RenewLoans1();
        }
        public static void ReturnBook()
        {
            ViewAllLoans();
            library.ReturnBook1();
        }

    }


}
