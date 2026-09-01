using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;

namespace Practice
{
    public abstract class LibraryItem
    {
        public int ItemId { get; }
        public string Title { get; }
        public string Creator { get; }

        protected LibraryItem(int itemId, string title, string creator)
        {
            ItemId = itemId;
            Title = title;
            Creator = creator;
        }

        public abstract int GetLoanDuration();
        public abstract bool CanRenew();
    }

    public class Book : LibraryItem
    {
        public Book(int itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 21;
        }

        public override bool CanRenew()
        {
            return true;
        }
    }

    public class Magazine : LibraryItem
    {
        public Magazine(int itemId, string title, string publisher)
            : base(itemId, title, publisher)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public override bool CanRenew()
        {
            return false;
        }
    }

    public class DVD : LibraryItem
    {
        public DVD(int itemId, string title, string producer)
            : base(itemId, title, producer)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public override bool CanRenew()
        {
            return true;
        }
    }

    public class LibraryItemCopy
    {
        public int CopyId { get; }
        public LibraryItem Item { get; }
        public string Status { get; private set; }

        public LibraryItemCopy(int copyId, LibraryItem item)
        {
            CopyId = copyId;
            Item = item;
            Status = "Available";
        }

        public void Checkout()
        {
            if (Status == "Available")
            {
                Status = "Borrowed";
            }
        }

        public void ReturnItem()
        {
            Status = "Available";
        }
    }

    public class Branch
    {
        public int BranchId { get; }
        public string Name { get; }

        private List<LibraryItemCopy> copies = new List<LibraryItemCopy>();

        public Branch(int branchId, string name)
        {
            BranchId = branchId;
            Name = name;
        }

        public void AddCopy(LibraryItemCopy copy)
        {
            copies.Add(copy);
        }

        public void DisplayCopies()
        {
            foreach (LibraryItemCopy copy in copies)
            {
                Console.WriteLine($"{copy.CopyId} - {copy.Item.Title} - {copy.Status}");
            }
        }
    }

    public class Library
    {
        public string Name { get; }

        private List<Branch> branches = new List<Branch>();

        public Library(string name)
        {
            Name = name;
        }

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }
    }

    public class Member
    {
        public int MemberId { get; }
        public string Name { get; }

        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
    }

    public class Loan
    {
        public int LoanId { get; }
        public Member Member { get; }
        public LibraryItemCopy Copy { get; }
        public DateTime LoanDate { get; }
        public DateTime DueDate { get; }
        public DateTime? ReturnDate { get; private set; }
        public bool Returned { get; private set; }

        public Loan(int loanId, Member member, LibraryItemCopy copy)
        {
            LoanId = loanId;
            Member = member;
            Copy = copy;
            LoanDate = DateTime.Now;
            DueDate = LoanDate.AddDays(copy.Item.GetLoanDuration());
            Returned = false;
        }

        public void ReturnItem()
        {
            Returned = true;
            ReturnDate = DateTime.Now;
            Copy.ReturnItem();
        }
    }

    public class Reservation
    {
        public int ReservationId { get; }
        public Member Member { get; }
        public LibraryItem Item { get; }
        public string Status { get; private set; }

        public Reservation(int reservationId, Member member, LibraryItem item)
        {
            ReservationId = reservationId;
            Member = member;
            Item = item;
            Status = "Active";
        }

        public void Cancel()
        {
            Status = "Cancelled";
        }
    }

    public class Librarian
    {
        public int LibrarianId { get; }
        public string Name { get; }

        public Librarian(int librarianId, string name)
        {
            LibrarianId = librarianId;
            Name = name;
        }

        public Loan Checkout(int loanId, Member member, LibraryItemCopy copy)
        {
            if (copy.Status != "Available")
            {
                throw new InvalidOperationException("Item is not available.");
            }

            copy.Checkout();

            return new Loan(loanId, member, copy);
        }

        public void ReturnItem(Loan loan)
        {
            loan.ReturnItem();
        }
    }

    class Review2
    {
        static void Main(string[] args)
        {
            Library library = new Library("Centeral Library");

            Branch branch1 = new Branch(1, " Branch1");
            Branch branch2 = new Branch(2, "Branch2");

            library.AddBranch(branch1);
            library.AddBranch(branch2);

            Book book = new Book(101, "OOPS", "xyz");


            Magazine magazine = new Magazine(102, "maagazine1", "abc");

            DVD dvd = new DVD(103, "DVD1", "hello");

            LibraryItemCopy copy1 = new LibraryItemCopy(1001, book);
            LibraryItemCopy copy2 = new LibraryItemCopy(1002, book);
            LibraryItemCopy copy3 = new LibraryItemCopy(1003, magazine);
            LibraryItemCopy copy4 = new LibraryItemCopy(1004, dvd);

            branch1.AddCopy(copy1);
            branch2.AddCopy(copy3);

            branch2.AddCopy(copy2);
            branch2.AddCopy(copy4);

            Member member1 = new Member(1, "Sneha");
            Member member2 = new Member(2, "kashish");

            Librarian librarian = new Librarian(101, "Nakul");

            Loan loan = librarian.Checkout(5001, member1, copy1);

            Console.WriteLine($"Member: {loan.Member.Name}");
            Console.WriteLine($"Book: {loan.Copy.Item.Title}");
            Console.WriteLine($"Due Date: {loan.DueDate}");
            Console.WriteLine($"Status: {loan.Copy.Status}");

            Reservation reservation = new Reservation(7001, member2, book);

            Console.WriteLine($"Reservation: {reservation.Status}");

            librarian.ReturnItem(loan);

            Console.WriteLine($"After return: {copy1.Status}");
        }
    }
}
