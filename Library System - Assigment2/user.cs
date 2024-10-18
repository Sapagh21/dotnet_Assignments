using System;
namespace LibraryUsers{
    // ------------------------
    //       USERS
    // ------------------------

    public  enum userTypes
    {
        Member,
        Librarian
    }

   public abstract class LibraryUser{
        public string name;
        public int memberID;
        public string email;

        public LibraryUser(string name, int memberID, string email = ""){
            this.name = name;
            this.memberID = memberID;
            this.email = email;
        }
        public virtual void borrowBook(Lib.Library lib,int bookID){
            lib.allBooks[bookID].borrowBook();
        }
        public virtual void returnBook(Lib.Library lib, int bookID){
            lib.allBooks[bookID].returnBook();
        }

    }

    public class Member: LibraryUser{
        private int borrowedBooks;

        public Member(string name, int memberID, string email = "",int borrowedBooks=0) : base(name, memberID,email) {
            this.name = name;
            this.memberID = memberID;
            this.email = email;
            this.borrowedBooks = borrowedBooks;
        }
        public override void borrowBook(Lib.Library lib, int bookID){

            
            if(borrowedBooks < 3 ){
            if (lib.allBooks[bookID].borrowBook() ){
                    borrowedBooks++;
                }
            }else{
                Console.WriteLine("Borrow limit excceded, please make sure to return borrowed books before trying to borrow new ones");
            }
            
        }

        public override void returnBook(Lib.Library lib, int bookID){
            lib.allBooks[bookID].returnBook();
            if (borrowedBooks>= 0){
                borrowedBooks--;
            }
        }
    }

    public class Librarian: LibraryUser{

        public Librarian(string name, int memberID, string email = "") : base(name, memberID,email) {
            this.name = name;
            this.memberID = memberID;
            this.email = email;
        }
        public void addBook(Lib.Library lib , string title, string author, string ISBN){
            lib.addBook(title, author, ISBN);
        }
    }

}