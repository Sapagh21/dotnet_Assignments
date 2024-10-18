 using System;
 using LibraryUsers;
 using Lib;
 using userType = LibraryUsers.userTypes;
 class Program{
        // Entry point
        static void Main(string[] args){
            // create library instance
            Library mylib = new Library();
            // Create some users

            mylib.addUser("Ahmed", type:userType.Librarian ); //id => 0
            mylib.addUser("seif","Ahmed@email.com");   //id => 1

            // i couldve just created another function that returns an object but meeeh (maybe later?)
            LibraryUsers.Librarian ahmed = (LibraryUsers.Librarian)mylib.allUsers[0];
            LibraryUsers.Member seif = (LibraryUsers.Member)mylib.allUsers[1]; // i have to explicitly cast since allUsers array is of type LibraryUser

            // Add books to the library by the librarian
                ahmed.addBook(mylib, "Hands-on C#", "tt", "124B");
                ahmed.addBook(mylib, "Learning Python", "Mark", "212PY");
                ahmed.addBook(mylib, "Data Structures & Algorithms", "John Doe", "323DS");    
                ahmed.addBook(mylib, "designing data intensitive apps", "Peter griffen", "323DS");

            // }    Uncommenting this line causes 99 Errors LOLXD (decided to leave it to remind me of how spaghetti my code is [should've planned ahead of time Y-Y])

            // Display all the  books in the library
            Console.WriteLine("List of Books:");
            mylib.displayBooks();

            // Member Ahmed[id=1] tries to borrow books
            Console.WriteLine("\nSeif is borrowing books:");
            seif.borrowBook(mylib, 0); // Borrow first book
            seif.borrowBook(mylib, 1); // Borrow 2nd '' 
            seif.borrowBook(mylib, 2); // Borrow 3rd ''

            // Testing borrowing an already borrowed book by same user
            seif.borrowBook(mylib, 0); // Borrow first book

            // Testing for the borrowing limit
            Console.WriteLine("\nSeif is borrowing the 4th book:");
            seif.borrowBook(mylib, 3); // Borrow 4th      

            // members tries to borrow a borrowed book by a different user
            Console.WriteLine("\nAhmed is borrowing a borrowed book:");
            ahmed.borrowBook(mylib,0);

            // ahmed tries to borrow an unborrowed book
            Console.WriteLine("\nAhmed is borrowing an unborrowed book:");
            ahmed.borrowBook(mylib,3);

            // Display available books after borrowing
            Console.WriteLine("\nList of Books after Seif borrowed:");
            mylib.displayBooks(); 

            // Return a book and check availability
            Console.WriteLine("\nSeif returns the first book:");
            seif.returnBook(mylib, 0); // Return "Hands-on C#"

            // Display available books after returning
            Console.WriteLine("\nList of Books after Seif returned a book:");
            mylib.displayBooks();

            // Ahmed borrows a book
            Console.WriteLine("\nAhmed is borrowing a book:");
            ahmed.borrowBook(mylib, 0); // Borrow "Hands-on C#"

            // Display available books after Ahmed borrows
            Console.WriteLine("\nList of Books after Ahmed borrowed:");
            mylib.displayBooks();
        }
    }