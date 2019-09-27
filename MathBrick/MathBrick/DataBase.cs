using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Windows.Forms;

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

        public bool WriteInDataBase(User newComer)
        {
            if (usersDic.ContainsKey(newComer.userName)) {
                MessageBox.Show("The username has been used. Please use another one.", "Oops"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            usersDic.Add(newComer.userName, newComer);
            File.WriteAllText(userListFileName, new JavaScriptSerializer().Serialize(usersDic));
            return true;
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
    }
}
