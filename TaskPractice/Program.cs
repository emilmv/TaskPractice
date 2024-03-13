using TaskPractice.Utils.Enums;

namespace TaskPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Emil", "Emil", Role.Admin);
            User user2= new User("SS","ss",Role.Member);
            User user3=new User("AA","bb",Role.Admin);

            user1.ShowInfo();
            Console.WriteLine("============");
            user2.ShowInfo();
        }
    }
}
