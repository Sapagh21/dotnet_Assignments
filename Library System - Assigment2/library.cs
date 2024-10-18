using System;
using LibraryUsers;
using userType = LibraryUsers.userTypes;
namespace Lib{
    public class Library{
        public Book[]  allBooks= new Book[100];
        public LibraryUsers.LibraryUser[] allUsers = new LibraryUser[100];
        public int booksCount;
        public int usersCount;
        public Library(){
            booksCount = 0;
            usersCount = 0;
        }
        public void addBook(string title, string author, string ISBN){
            if (booksCount < allBooks.Length) {
                allBooks[booksCount] =  new Book(title,author,ISBN,true);
                Console.WriteLine($"\"{title}\" book __ bookID = {booksCount} || has been added...");
                booksCount++;
                
            }else{
                Console.WriteLine("Cannot Add More Books, Library is full!");
            }
        }
        
        public void addUser(string name, string email="", userType type = userType.Member){
            if (usersCount < allUsers.Length) {
                if (type == userType.Member){
                    allUsers[usersCount] =  new LibraryUsers.Member(name,usersCount,email);
                }else{
                    allUsers[usersCount] =  new LibraryUsers.Librarian(name,usersCount,email);
                }

                Console.WriteLine($"{type} - {name} | Has been Registered ");
                usersCount ++;
                
            }else{
                Console.WriteLine("Sorry! no more users can be added");
            }
        }
        public void displayBooks(){
            Console.WriteLine("[id] - Title       Is Available?");

            for(int i = 0; i<booksCount; i++){
                Console.WriteLine($"[{i}] - {allBooks[i].title}    {allBooks[i].isAvailable()}");
            }
        }
        public bool isAvailable(int bookID){
            return allBooks[bookID].isAvailable();
        }

        public void borrowBook(int bookID, int memberID){
            allBooks[bookID].borrowBook();
        }


        public void returnBook(int bookID,int memberID){
            allBooks[bookID].returnBook();
        }
    }
}