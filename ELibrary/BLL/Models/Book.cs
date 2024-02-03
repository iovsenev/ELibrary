using System.Xml;

namespace ELibrary.DLL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string? Description { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is  Book))
                return false;
            var second = obj as Book;
            return (Id == second.Id);
        }

        public override string ToString()
        {
            return $"ID = {Id}, Title: {Name}, Year: {Year}.";
        }
    }
}
