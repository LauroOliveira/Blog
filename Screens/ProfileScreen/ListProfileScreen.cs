using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ProfileScreen
{
    public static class ListProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de perfil");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var item in roles)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}