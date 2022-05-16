using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBros.Model
{
    internal class UserInfo
    {
        public string ID;
        public string Name;
        public string Age;
        public string Sex;
        public string Address;

        public UserInfo(string id, string name, string age, string sex, string address)
        {
            ID = id;
            Name = name;
            Age = age;
            Sex = sex;
            Address = address;
        }
    }
}
