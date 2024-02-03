using ELibrary.BLL.Exceptions;
using ELibrary.DAL.Connectors;
using ELibrary.DLL.Models;

namespace ELibrary.DAL.Repositories
{
    internal class BookRepository 
    {
        public List<Book> FindAll()
        {
            using (var database = new AppDbContext())
            {
                return database.Books.ToList();
            }
        }

        public Book FindById(int id)
        {
            using (var database = new AppDbContext())
            {
                var book = database.Books.Where(u => u.Id == id).FirstOrDefault();
                if (book == null) throw new NotFoundUserException();
                return book;
            }
        }

        public void Add(Book book)
        {
            using (var database = new AppDbContext())
            {
                database.Books.Add(book);
                database.SaveChanges();
            }
        }

        public void Remove(Book book)
        {
            using (var database = new AppDbContext())
            {
                database.Books.Remove(book);
                database.SaveChanges();
            }
        }

        public void UpdateYearById(int id, string newYear)
        {
            using (var database = new AppDbContext())
            {
                var user = database.Books.Where(b => b.Id == id).FirstOrDefault();
                if (user == null) throw new NotFoundUserException();
                user.Year = newYear;
                database.SaveChanges();
            }
        }
    }
}
