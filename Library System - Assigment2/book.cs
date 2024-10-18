namespace Lib{
    // ------------------------
    // BOOK Class
    // ------------------------
    public class Book{
       public string title;
        public string author;
        public string ISBN;
        public bool availabilityStatus ;

        public Book(string title, string author, string ISBN, bool availabilityStatus = false){
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.availabilityStatus = availabilityStatus;
        }

        public bool borrowBook(){
            if (isAvailable()){
                availabilityStatus = false;
                Console.WriteLine($"You have borrowed {title}");
                return true;
            }else{
                Console.WriteLine($"{title} is not available");
                return false;
            }
        }        

        public void returnBook(){
            availabilityStatus = true;
            Console.WriteLine($"You have returned '{title}'."); 
        }        
        public bool isAvailable(){
            return availabilityStatus;
        }
    }

}