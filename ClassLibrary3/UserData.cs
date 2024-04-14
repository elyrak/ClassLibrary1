using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountDataService
{
    public class UserData
    {
        List<UserData> dummyuser = new List<UserData>();
        public string userName;
        public string userID;

        public UserData()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            UserData user1 = new UserData();
            user1.userName = "Aldrin_Marupok";
            user1.userID = "A-090631";
            

            UserData user2 = new UserData();
            user2.userName = "Evelyn_Ha";
            user2.userID = "E-011203";
            

            UserData user3 = new UserData();
            user3.userName = "Karyle_Anne";
            user3.userID = "KA-022204";
            

            UserData user4 = new UserData();
            user4.userName = "Yoko_Aspara";
            user4.userID = "Y-0101010";
            

            dummyuser.Add(user1);
            dummyuser.Add(user2);
            dummyuser.Add(user3);
            dummyuser.Add(user4);

        }

      

        public UserData GetUser(String userName, String userID)
        {
            UserData foundUser = new UserData();
            foreach (var dummy in dummyuser)
            {
                if (userName != dummy.userName )
                {
                    continue;
                }
                foundUser = dummy;

            }
            return foundUser;
        }

    }
}

