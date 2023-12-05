using Blog.Models;
using Blog.Repositories;

namespace blog.Screens.UsersScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Blog.Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Email}, {item.PasswordHash}, {item.Bio}, {item.Image}, ({item.Slug})");
        }
    }
}