/* Pre-Refactored code
    before Seperating the classes into different files
*/

// using System;
// namespace LibrarySys
// {

//     class Program{
//         // Entry point
//         static void Main(string[] args){
//             // library object
//             Library mylib = new Library();

//             // adding users through the library class (testing)
//             // mylib.addUser("ss","ss",userTypes.Member)

//             // Create some users
//             Member seif = new Member();
//             Member ahmed = new Member();
//             Librarian aly = new Librarian();

//             // Add books to the library by the librarian
//             aly.addBook(mylib, "Hands-on C#", "tt", "124B");
//             aly.addBook(mylib, "Learning Python", "Mark", "212PY");
//             aly.addBook(mylib, "Data Structures & Algorithms", "John Doe", "323DS");
//             aly.addBook(mylib, "designing data intensitive apps", "Peter griffen", "323DS");

//             // Display all the  books in the library
//             Console.WriteLine("List of Books:");
//             mylib.displayBooks();

//             // Member seif tries to borrow books
//             Console.WriteLine("\nSeif is borrowing books:");
//             seif.borrowBook(mylib, 0); // Borrow first book
//             seif.borrowBook(mylib, 1); // Borrow 2nd '' 
//             seif.borrowBook(mylib, 2); // Borrow 3rd ''

//             // Testing borrowing an already borrowed book by same user
//             seif.borrowBook(mylib, 0); // Borrow first book

//             // Testing for the borrowing limit
//             Console.WriteLine("\nSeif is borrowing the 4th book:");
//             seif.borrowBook(mylib, 3); // Borrow 4th      

//             // members tries to borrow a borrowed book by a different user
//             Console.WriteLine("\nAhmed is borrowing a borrowed book:");
//             ahmed.borrowBook(mylib,0);

//             // ahmed tries to borrow an unborrowed book
//             Console.WriteLine("\nAhmed is borrowing an unborrowed book:");
//             ahmed.borrowBook(mylib,3);
//             mylib.AddBook()
//             // Display available books after borrowing
//             Console.WriteLine("\nList of Books after Seif borrowed:");
//             mylib.displayBooks(); 

//             // Return a book and check availability
//             Console.WriteLine("\nSeif returns the first book:");
//             seif.returnBook(mylib, 0); // Return "Hands-on C#"

//             // Display available books after returning
//             Console.WriteLine("\nList of Books after Seif returned a book:");
//             mylib.displayBooks();

//             // Ahmed borrows a book
//             Console.WriteLine("\nAhmed is borrowing a book:");
//             ahmed.borrowBook(mylib, 0); // Borrow "Hands-on C#"

//             // Display available books after Ahmed borrows
//             Console.WriteLine("\nList of Books after Ahmed borrowed:");
//             mylib.displayBooks();
//         }
//     }


//     // ------------------------
//     //        Library
//     // ------------------------
    
//      class Library{
//         public Book[]  allBooks= new Book[100];
//         private LibraryUser[] allUsers = new LibraryUser[100];
//         private int booksCount;
//         private int usersCount;
//         public Library(){
//             booksCount = 0;
//             usersCount = 0;
//         }
//         public void AddBook(string title, string author, string ISBN){
//             if (booksCount < allBooks.Length) {
//                 allBooks[booksCount] =  new Book(title,author,ISBN,true);
//                 Console.WriteLine($"\"{title}\" book __ bookID = {booksCount} || has been added...");
//                 booksCount++;
                
//             }else{
//                 Console.WriteLine("Cannot Add More Books, Library is full!");
//             }
//         }

//         // this is unfinished cause i was just checking how it will be like to make the user type an enum
//         // public void addUser(string name, string email, userTypes type){
//         //     if (usersCount < allUsers.Length) {
//         //         // allUsers[usersCount] =  new Member()
//         //         Console.WriteLine($"\"{title}\" book __ bookID = {booksCount} || has been added...");
//         //         booksCount++;
                
//         //     }else{
//         //         Console.WriteLine("Sorry! no more users can be added");
//         //     }
//         // }

//         public void displayBooks(){
//             Console.WriteLine("[id] - Title       Is Available?");

//             for(int i = 0; i<booksCount; i++){
//                 Console.WriteLine($"[{i}] - {allBooks[i].title}    {allBooks[i].isAvailable()}");
//             }
//         }
//         public bool isAvailable(int bookID){
//             return allBooks[bookID].isAvailable();
//         }

//         public void borrowBook(int bookID, int memberID){
//             allBooks[bookID].borrowBook();
//         }


//         public void returnBook(int bookID){
//             allBooks[bookID].returnBook();
//         }
//     }


//     // ------------------------
//     // BOOK Class
//     // ------------------------
//     class Book{
//        public string title;
//         private string author;
//         private string ISBN;
//         private bool availabilityStatus ;

//         public Book(string title, string author, string ISBN, bool availabilityStatus = false){
//             this.title = title;
//             this.author = author;
//             this.ISBN = ISBN;
//             this.availabilityStatus = availabilityStatus;
//         }

//         public bool borrowBook(){
//             if (isAvailable()){
//                 availabilityStatus = false;
//                 Console.WriteLine($"You have borrowed {title}");
//                 return true;
//             }else{
//                 Console.WriteLine($"{title} is not available");
//                 return false;
//             }
//         }        

//         public void returnBook(){
//             availabilityStatus = true;
//             Console.WriteLine($"You have returned '{title}'."); 
//         }        
//         public bool isAvailable(){
//             return availabilityStatus;
//         }
//     }



//     // ------------------------
//     //       USERS
//     // ------------------------

    
//     public  enum userTypes
//     {
//         Member,
//         Librarian
//     }

//    class LibraryUser{
//         private string name;
//         private string memberID;
//         private string email;

//         public virtual void borrowBook(Library lib,int bookID){
//             lib.allBooks[bookID].borrowBook();
//         }
//         public virtual void returnBook(Library lib, int bookID){
//             lib.allBooks[bookID].returnBook();
//         }

//     }

//     class Member: LibraryUser{
//         private int borrowedBooks;

//         public Member(){
//             borrowedBooks = 0;
//         }
//         public override void borrowBook(Library lib, int bookID){

            
//             if(borrowedBooks < 3 ){
//             if (lib.allBooks[bookID].borrowBook() ){
//                     borrowedBooks++;
//                 }
//             }else{
//                 Console.WriteLine("Borrow limit excceded, please make sure to return borrowed books before trying to borrow new ones");
//             }
            
//         }

//         public override void returnBook(Library lib, int bookID){
//             lib.allBooks[bookID].returnBook();
//             if (borrowedBooks>= 0){
//                 borrowedBooks--;
//             }
//         }
//     }

//     class Librarian: LibraryUser{
//             public void addBook(Library lib , string title, string author, string ISBN){
//             lib.AddBook(title, author, ISBN);
//         }
//     }

// }
