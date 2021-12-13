using System;

namespace Collections
{
    public class User : IUser
    {
        public User(string fullName, string username, uint? age)
        {
            /*
            if (username == null)
            {
                throw new NotImplementedException("ensure that username is not null");
            }
            else if (username == null || !age.HasValue)
            {
                throw new NotImplementedException("initialise this instance of user accordingly");

            }
            */
            FullName = fullName;
            Username = username;
            Age = age;
        }

        public uint? Age { get; }

        public string FullName { get; }

        public string Username { get; }

        public bool IsAgeDefined => Age != null;

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj != null)
            {
                User user = (User)obj;
                return FullName.Equals(user.FullName)
                    && Username.Equals(user.Username)
                    && Age == user.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return FullName.GetHashCode() ^ Username.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{FullName}, {Username}, {Age}]";
        }

        // TODO implement missing methods (try to autonomously figure out which are the necessary methods)
    }
}
