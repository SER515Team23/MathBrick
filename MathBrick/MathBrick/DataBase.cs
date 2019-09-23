using System;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace MathBrick
{
    sealed class DataBase
    {
        private static DataBase instance;
        private static String userListFileName = "UsersList.txt";
        private List<User> users { get; set; }
        private DataBase()
        {
            users = ReadDataBase();
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
        private List<User> ReadDataBase()
        {
            var userList = new List<User>();
            if (File.Exists(userListFileName)) {
                userList = new JavaScriptSerializer()
                        .Deserialize<List<User>>(File.ReadAllText(userListFileName));
            }
            return userList;
        }

        public void WriteInDataBase(User newComer)
        {
            users.Add(newComer);
            File.WriteAllText(userListFileName, new JavaScriptSerializer().Serialize(users));
        }
    }
}
