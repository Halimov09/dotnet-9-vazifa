using System.Security.Cryptography;

namespace BOOK.Classes
{
    public class Books
    {
        public string bookName;
        private string bookAfter;
        public int bookCost {get; set;}
        public int bookSale;
        public  Books (string name, string after, int cost)
        {
            bookName = name;
            bookAfter = after;
            bookCost = cost;
        }

        public string BookAfter
        {
            get {return bookAfter;}
            set {bookAfter = value;}
        }
        public void allShow ()
        {
            Console.WriteLine($"Kitobning nomi: {bookName}, yozuvchisi {bookAfter}, va kitob narhi: {bookCost} sum");
        }

        public void sale ()
        {
            bookSale = bookCost / 100 * 80;
            Console.WriteLine($"Bu {bookName} bitob 20% chegirma bilan siz uchun {bookSale}");
        }
    }
}