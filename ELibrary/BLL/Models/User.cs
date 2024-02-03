namespace ELibrary.DLL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if(!(obj is User))
                return false;
            var second = obj as User;
            return (Id == second.Id);
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
