using Library_System;
Library library = new Library();
Book book = new Book("book1","author1","123-456",true);

library.AddBook(book);

library.BorrowBook(book);

library.ReturnBook(book.Title);