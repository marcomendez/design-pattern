using System;

namespace SOLID.OpenClose
{
    public class BaseUser
    {
        public int Id { set; get; }
        public string Name { set; get; }


        public BaseUser(string typeUser)
        {
            Console.WriteLine($"Login from {typeUser} ");
        }
    }
}
