using Blog.Models;
using Blog.Repositories;

namespace blog.Screens.UsersScreens
{
    public static class DeleteUserScreen
    {
        
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um Usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do usuário que deseja exluir? ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Blog.Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}