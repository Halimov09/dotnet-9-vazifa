using BOOK.Classes;
Console.Write("Kitobning nomi: ");
string name = Console.ReadLine();


Console.Write("Kitob mualliffi: ");
string afterName = Console.ReadLine();

Console.Write("Kitob narhi: ");
int cost = int.Parse(Console.ReadLine());



Books bok = new Books(name: "Dunyoning ishlari", after: "Utkir hoshimov", cost: 45000);
Books bok1 = new Books(name, afterName, cost);


bok.allShow();
Console.WriteLine($"Kitobning nomi: {bok1.bookName}, yozuvchisi {bok1.BookAfter}, va kitob narhi: {bok1.bookCost} sum");
bok1.sale();
