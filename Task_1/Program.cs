


using Task_1;

Book book_1 = new Book("Tojikon", "Bobojon Gafurov", 2011);
if (book_1.IsPublishedRecently() == true) book_1.GetInfo();
if (book_1.IsPublishedRecently() == false) Console.WriteLine($"Book's : {book_1.Title} printed before 2010");