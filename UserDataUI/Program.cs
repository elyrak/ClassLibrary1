using UserAccountBusiness;

namespace UserDataUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter UserID: ");
            string userID = Console.ReadLine();


            AccountService dataService = new AccountService();
            bool result = dataService.VerifyUser(userName, userID);

            if(result)
            {
                Console.WriteLine("Welcome User!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
