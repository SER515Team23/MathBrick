using System;

/* 
 * Author: Yu-Ting Tsao
 * Description: A User object class.
*/

namespace MathBrick
{
    public class User: IEquatable<User>
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool isLogin { get; set; }
        public int authorizeLevel { get; set; }

        public bool Equals(User other)
        {
            return this.userName == other.userName;
        }
    }
}
