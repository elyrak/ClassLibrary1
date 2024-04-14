using UserAccountDataService;
using UserDataModel;
using System;

namespace UserAccountBusiness
{
    public class AccountService
    {
        public static bool Verification(string userName, string userID)
        {
            UserData userData = new UserData();
            var result = userData.GetUser(userName, userID);

            if(result.userName == userName && result.userID == userID)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}

































//namespace UserDataUI

   // internal class Program
// {
    //static void Main(string[] args)
   // {
   //     Console.WriteLine("Enter your UserName: ");
     //   string userName = Console.ReadLine();

      //  Console.WriteLine("Enter UsesrID: ");
      //  string userID = Console.ReadLine();

       // AccountService veri = new AccountService();
       // bool result = veri.Verification(userName, userID);

       // if(result)
      //  {
      //      Console.WriteLine("Welcome User!");

       // }
  //  }
// }

    