using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ProfileScreen
{
    public static class UpdateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um perfil");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role
            {
                Id = int.Parse(id ?? "Id nulo"),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuProfileScreen.Load();
        }

        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                Console.WriteLine("Perfil atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}