using TaskPractice.Utils.Constants;
using TaskPractice.Utils.Enums;

namespace TaskPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inputUsername:
            Console.WriteLine(Role.Admin.ToString());
            Console.WriteLine(ResponseMessage.UsernameInput);
            Console.WriteLine(ResponseMessage.Divider);
            string? username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine(ResponseMessage.NullReferenceException);
                Console.WriteLine(ResponseMessage.Divider);
                goto inputUsername;
            }
        inputEmail:
            Console.WriteLine(ResponseMessage.EmailInput);
            Console.WriteLine(ResponseMessage.Divider);
            string? email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine(ResponseMessage.NullReferenceException);
                Console.WriteLine(ResponseMessage.Divider);
                goto inputEmail;
            }
        roleInput:
            Console.WriteLine(ResponseMessage.RoleInput);
            Console.WriteLine(ResponseMessage.Divider);
            Console.WriteLine("Press 1 to choose Admin");
            Console.WriteLine("Press 2 to choose Member");
            bool isCorrectInput = int.TryParse(Console.ReadLine(), out int result);
            if (!isCorrectInput)
            {
                Console.WriteLine(ResponseMessage.WrongInput);
                goto roleInput;
            }
            switch (result)
            {
                case 1:
                    User admin = new(username, email, Role.Admin);
                    Console.WriteLine(ResponseMessage.Divider);
                    admin.ShowInfo();
                    break;
                case 2:
                    User member = new(username, email, Role.Member);
                    Console.WriteLine(ResponseMessage.Divider);
                    member.ShowInfo();
                    break;
                default:
                    goto roleInput;
            }





        }
    }
}
