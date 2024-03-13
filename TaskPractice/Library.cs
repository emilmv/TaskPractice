using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using TaskPractice.Interfaces;
using TaskPractice.Utils.Constants;
namespace TaskPractice
{
    internal class Library : IEntity
    {
        static int BookLimit = 5;
        private Book[] books = new Book[0];











        public void addBook(Book bookName)
        {

            if (bookName.isDeleted == false)
            {
                foreach (Book book in books)
                {
                    if (book.Name == bookName.Name)
                    {
                        Console.WriteLine(ResponseMessage.AlreadyExistsException);
                        return;
                    }
                    else
                    {
                        Array.Resize(ref books, books.Length + 1);
                        if (books.Length > BookLimit)
                        {
                            Console.WriteLine(ResponseMessage.CapacityLimitException);
                        }
                        books[books.Length - 1] = bookName;
                    }

                }
            }




        }

        public void getBookById(int? id)
        {
            foreach (Book book in books)
            {
                if (book.isDeleted == false)
                {
                    if (id == null)
                    {
                        Console.WriteLine(ResponseMessage.NullReferenceException);
                        return;
                    }
                    if (id == book.Id)
                        book.ShowInfo();
                }
            }
        }

        public void getAllBooks()
        {
            Book[] newBook = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
            {
                newBook[i] = books[i];
            }
            foreach (Book book in newBook)
                Console.WriteLine(book.Name);
        }

        public void deleteBookById(int? id)
        {
            foreach (Book book in books)
            {
                if (id == null)
                {
                    Console.WriteLine(ResponseMessage.NullReferenceException);
                }
                if (book.Id == id)
                    book.isDeleted = true;
                else Console.WriteLine(ResponseMessage.NotFountException);
            }
        }

        public void editBookName(int? id, string newName)
        {
            if (id == null)
            {
                Console.WriteLine(ResponseMessage.NullReferenceException);
                return;
            }
            foreach (Book book in books)
            {
                if (book.Id == id && book.isDeleted == false)
                {
                    book.Name = newName;
                    return;
                }
            }
            Console.WriteLine(ResponseMessage.NotFountException);
        }
        public void filterByPageCount(int minPageCount, int maxPageCount)
        {
            foreach(Book book in books)
            {
                if (book.isDeleted == false)
                {
                    if (book.PageCount > minPageCount && book.PageCount < maxPageCount)
                    {
                        Console.WriteLine(book.Name);
                    }
                }
            }
        }

    }
}
