using System;
using System.Collections.Generic;
using System.Text;

namespace Syscotech
{
    class Library
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        List<Loan> loans = new List<Loan>();

        public Library()
        {
            books.Add(new Book(1, "title1", "author1", 111, 5, "LENDING"));
            books.Add(new Book(2, "title2", "author2", 222, 5, "PR"));
            books.Add(new Book(3, "title3", "author3", 333, 5, "PR"));
            books.Add(new Book(4, "title4", "author4", 444, 5, "LENDING"));


            members.Add(new Member("Pasindu", 01, 0, "A"));
            members.Add(new Member("Navidu ", 02, 0, "B"));
            members.Add(new Member("Dhanish", 03, 0, "C"));

            //loans.Add(new Loan());

        }
        public void DisplayBooks()
        {
            foreach (Book book in books)
            {

                Console.WriteLine("\t{0, 4} {1, 8} {2, 21} {3, 16} {4,10} {5,25} ", book.Id1, book.Title, book.Author, book.Isbn, book.Copies, book.ItemType);
            }
        }
        public void DisplayMembers()
        {
            foreach (Member member in members)
            {
                Console.WriteLine("\t{0,4} {1,9} {2,7} {3,30}", member.Name, member.MemId1, member.SubscriptionLevel, member.Numberofbookborrow);
            }
        }
        public void BookBorrow()
        {

            int choice2 = checkMember();
            int choice1 = checkBook();
            /*  foreach (Book book in books)
              {
                  if (choice1 == book.Id1)
                  {
                      Console.WriteLine(book.Isbn);
                      break;
                  }
                  else;
                  Console.WriteLine("not find");
              }


              foreach(Member member in members)
              {
                  if(choice2 == member.MemId1)
                  {
                      Console.WriteLine(member.Name);
                  }
              }*/
            foreach (Book book in books)
            {
                foreach (Member member in members)
                {
                    if ((choice1 == book.Id1) && (choice2 == member.MemId1)) //to find book and member in the list
                    {
                        if (book.ItemType == "LENDING")
                        {
                            //Console.WriteLine(book.Isbn);
                            // Console.WriteLine(member.Name);
                            //Console.WriteLine(member.SubscriptionLevel);
                            if (member.SubscriptionLevel == "A")
                            {
                               
                                if (book.Copies > 0)
                                {

                                    if (member.Numberofbookborrow < 3)
                                    {
                                        Console.WriteLine("Book borrowed");
                                        member.BorrowedIncrease();
                                        book.CopiesDecrease();
                                        int Bid = book.Id1;
                                        string Bname = member.Name;
                                        int MemId = member.MemId1;
                                        createLoan(Bid, Bname, MemId);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Can't borrow more than 3 books");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Out of stock");
                                }

                                //Console.WriteLine(book.Copies);

                            }
                            if (member.SubscriptionLevel == "B")
                            {
                                //Console.WriteLine("123");

                                // book.CopiesDecrease();
                                // Console.WriteLine(book.Copies);
                                // member.BorrowedIncrease();
                                if (book.Copies > 0)
                                {

                                    if (member.Numberofbookborrow < 2)
                                    {
                                        Console.WriteLine("Book borrowed");
                                        member.BorrowedIncrease();
                                        book.CopiesDecrease();
                                        int Bid = book.Id1;
                                        int MemId = member.MemId1;
                                        string Bname = member.Name;
                                        createLoan(Bid, Bname, MemId);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Can't borrow more than 2 books");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Out of stock");
                                }

                            }
                            if (member.SubscriptionLevel == "C")
                            {
                                //Console.WriteLine("123");

                                // book.CopiesDecrease();
                                // Console.WriteLine(book.Copies);
                                // member.BorrowedIncrease();
                                if (book.Copies > 0)
                                {

                                    if (member.Numberofbookborrow < 1)
                                    {
                                        Console.WriteLine("Book borrowed");
                                        member.BorrowedIncrease();
                                        book.CopiesDecrease();
                                        int Bid = book.Id1;
                                        int MemId = member.MemId1;
                                        string Bname = member.Name;
                                        createLoan(Bid, Bname, MemId);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Can't borrow more than 1 books");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Out of stock");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Can't borrow PR items");
                        }
                        break;
                    }

                    
                }
               
            }
            
        }


        public static int checkMember()
        {
            try
            {
                Console.Write("Member Id:");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter number");
                
                return checkMember();
                
            }
        }
        public static int checkBook()
        {
            try
            {
                Console.Write("Book ID:");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter number");
               return checkBook();
                
            }
        }



        public void createLoan(int Bid, string Bname, int MemId)
        {

            Console.WriteLine();
            loans.Add(new Loan(Bid, MemId, Bname, DateTime.Now, DateTime.Today.AddDays(7), 0));

        }
        public void DisplayLoans()
        {
            foreach (Loan loan in loans)
            {

                Console.WriteLine("\t{0, 4} {1, 12} {2, 23} {3, 25}{4,15}{5,11}{6,14}", loan.BookId1, loan.Name, loan.LoanDate, loan.ReturnDate, loan.Renewals1, loan.MemID1, loan.LoanId);
            }
        }
        public static int checkLoan()
        {
            try
            {
                Console.Write("Loan Id:");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter number");
                return checkLoan();
            }
        }

        public void RenewLoans1()
        {
            DisplayLoans();
            int choice2 = checkMember();
            int choice1 = checkBook();
            int choice3 = checkLoan();

            foreach (Loan loan in loans)
            {
                if ((choice1 == loan.BookId1) && (choice2 == loan.MemID1) && (choice3 == loan.LoanId))
                {
                    if (loan.Renewals1 < 1)
                    {
                        loan.RenewIncrease();
                        loan.ReturnDateIncrease();
                        // Console.WriteLine("\t{0, 4} {1, 12} {2, 23} {3, 25}{4,15}", loan.BookId1, loan.Name, loan.LoanDate, loan.ReturnDate, loan.Renewals1);
                        Console.WriteLine("loan Extended for 7 days");
                    }
                    else
                    {
                        Console.WriteLine("Cant Extended");
                    }
                }
            }


        }
        
        public void ReturnBook1()
        {
            int choice2 = checkMember();
            int choice1 = checkBook();
            int choice3 = checkLoan();

            try
            {
                foreach (Loan loan in loans)
                {
                    foreach (Member member in members)
                    {
                        foreach (Book book in books)
                        {

                            if ((choice1 == loan.BookId1) && (choice2 == loan.MemID1) && (choice3 == loan.LoanId))
                            {

                                if (member.Numberofbookborrow > 0)
                                {
                                    book.CopiesIncrease();
                                    member.BorrowedDecrease();


                                    // ClearLoan();
                                    var findLoan = loans.Find(loans => loans.LoanId == choice3);
                                    if (findLoan != null)
                                    {
                                        loans.Remove(findLoan);
                                    }
                                }

                            }
                            break;

                        }


                    }



                }
            }
            catch (Exception)
            {
                 Console.WriteLine(); ;
            }

        }

    }
}


