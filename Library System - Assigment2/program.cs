 /*

========================= Problem Statement =========================
Designing a Library Management System in C# Using Object-Oriented Programming (OOP)

Problem Overview:
    You need to create a system to manage the books in a library, handle user
    interactions like borrowing and returning books, and keep track of users. The
    system should allow for multiple types of users (e.g., Members and Librarians)
    who can perform different tasks.

Requirements:
    1- Book:
        Each book should have a title, author, ISBN, and availability status.
        Provide methods to borrow and return a book.

    2- Library User (Abstract Class):
        Define an abstract class LibraryUser with properties like name, membershipID, and email.
        Define methods to borrow and return a book. Each type of user will have different behaviors for borrowing/returning books.

    3- Member (Derived Class):
        A Member can borrow a limited number of books (e.g., 3 books at a time).
        Members should be able to borrow books, but only if they are available, and return them when done.

    4- Librarian (Derived Class):
        A Librarian has the ability to add new books to the library collection.
        Librarians can borrow and return books like members but have no limit on the number of books they can borrow at once.

    5- Library:
        Create a Library class that manages a collection of books and users.
        The Library class should provide functionality to:
            Add new books to the collection.
            Display available books.
            Check if a book is available or borrowed.
            Handle borrowing and returning of books by users

 */

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