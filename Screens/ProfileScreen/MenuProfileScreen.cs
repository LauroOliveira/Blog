using System;

namespace Blog.Screens.ProfileScreen
{
    public static class MenuProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de perfil");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar perfis");
            Console.WriteLine("2 - Cadastrar perfil");
            Console.WriteLine("3 - Atualizar perfil");
            Console.WriteLine("4 - Excluir perfil");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine() ?? "");

            switch (option)
            {
                case 1:
                    ListProfileScreen.Load();
                    break;
                case 2:
                    CreateProfileScreen.Load();
                    break;
                case 3:
                    UpdateProfileScreen.Load();
                    break;
                case 4:
                    DeleteProfileScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;     
                    
                default: Load(); break;
            }
        }
    }
}