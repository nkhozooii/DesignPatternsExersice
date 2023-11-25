using Strategy.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new User[]
            {
              new User { Id = 101 ,Credit=5000,Name="Ehsan" ,LastName="Babaei"},
              new User {Id = 105 ,Credit=8000,Name="Roshan" ,LastName="Ahmadi"},
              new User {Id = 109,Credit=3000, Name="Ali" ,LastName="Ahmadi"},
            };
            Console.WriteLine("----------------Befor Sort------------");
            foreach (var item in users)
            {
                item.DisplayUser();
            }
            Console.WriteLine("----------------After Sort------------");

            Array.Sort(users, new UserByCredit_Comparer());
            foreach (var item in users)
            {
                item.DisplayUser();
            }


            Array.Sort(users, new UserById_Comparer());
            Console.WriteLine("----------------After Sort By Id------------");
            foreach (var item in users)
            {
                item.DisplayUser();
            }
        }




    }
    //These are Concrete Strategies and IComparer is Strategy
    public class UserByCredit_Comparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (x.Credit == y.Credit)
                return 0;
            else if (x.Credit > y.Credit)
                return 1;
            else
                return -1;
        }
    }


    public class UserById_Comparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (x.Id == y.Id)
                return 0;
            else if (x.Id > y.Id)
                return 1;
            else
                return -1;
        }
    }
}
