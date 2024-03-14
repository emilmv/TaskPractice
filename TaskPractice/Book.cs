using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPractice.Interfaces;

namespace TaskPractice
{
    public class Book : IEntity
    {
        private static int idCount = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        private bool _isDeleted = false;
        public bool isDeleted
        {
            get => _isDeleted;
            set
            {
                _isDeleted = value;
            }
        }

        public Book(string name, string authorName, int pageCount)
        {
            Id = idCount++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
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
