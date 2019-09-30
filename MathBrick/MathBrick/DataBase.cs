using System;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace MathBrick
{
    sealed class DataBase
    {
        // If you need the current user information, access this instance.
        public User activeUser = null;

        private static DataBase instance;
        private static string userListFileName = "UsersList.txt";
        private Dictionary<string, User> usersDic;
        private DataBase()
        {
            usersDic = ReadDataBase();
        }
        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                }
                return instance;
            }
        }
        private Dictionary<string ,User> ReadDataBase()
        {
            var booksDic = new Dictionary<string, User>();
            if (File.Exists(userListFileName)) {
                booksDic = new JavaScriptSerializer()
                        .Deserialize<Dictionary<string, User>>(File.ReadAllText(userListFileName));
            }
            return booksDic;
        }

        public void WriteInDataBase(User newComer)
        {
            usersDic.Add(newComer.userName, newComer);
            File.WriteAllText(userListFileName, new JavaScriptSerializer().Serialize(usersDic));
        }

        public bool UserLogin(string userName, string inputPwd)
        {
            if (usersDic.ContainsKey(userName))
            {
                string correctPwd = usersDic[userName].password;
                if (correctPwd == inputPwd)
                {
                    usersDic[userName].isLogin = true;
                    activeUser = usersDic[userName];
                    return true;
                }
            }
            return false;
        }

        public int CheckAuthorize(string userName)
        {
            if (usersDic.ContainsKey(userName))
            {
                return usersDic[userName].authorizeLevel;
            }
            else
                return -1;
        }
    }
}
