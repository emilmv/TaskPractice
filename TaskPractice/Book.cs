using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractice.Interfaces;

namespace TaskPractice
{
    internal class Book : IEntity
    {
        private static int idCount = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            Id= idCount++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }


        public bool isDeleted()
        {
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(AuthorName);
            Console.WriteLine(PageCount);
        }
    }
}
