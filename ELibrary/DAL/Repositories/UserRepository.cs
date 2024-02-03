using ELibrary.DLL.Models;
using ELibrary.DAL.Connectors;
using ELibrary.BLL.Exceptions;

namespace ELibrary.DAL.Repositories
{
    public class UserRepository 
    {
        public List<User> FindAll()
        {
            using (var database = new AppDbContext())
            {
                return database.Users.ToList();
            }
        }

        public User FindById(int id)
        {
            using (var database = new AppDbContext())
            {
                var user = database.Users.Where(u => u.Id == id).FirstOrDefault();
                if (user == null) throw new NotFoundUserException();
                return user;
            }
        }

        public void Add(User user)
        {
            using (var database = new AppDbContext())
            {
                database.Users.Add(user);
                database.SaveChanges();
            }
        }

        public void Remove(User user)
        {
            using (var database = new AppDbContext())
            {
                database.Users.Remove(user);
                database.SaveChanges();
            }
        }

        public void UpdateNameById(int id, string newName)
        {
            using (var database = new AppDbContext())
            {
                var user = database.Users.Where(u => u.Id == id).FirstOrDefault();
                if (user == null) throw new NotFoundUserException();
                user.Name = newName;
                database.SaveChanges();
            }
        }
    }
}
