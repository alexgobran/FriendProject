using System;
using System.Collections.Generic;
namespace Friend_Project {
    class Program {
        static void Main(string[] args) {
            //  creating a List      (variable name)
            List<int> integers = new List<int>();
            integers.Add(17);
            integers.Add(0);
            integers.Add(88);
            integers.Add(43);
            var count = integers.Count;  //how many items in cllection
            integers.Sort();
            integers.Remove(0);

            var f1 = new Friend("Bob", "513-322-4544", "bi@gmail.com", true, 1);
            var f2 = new Friend("Bill", "513-322-4544", "bi@gmail.com", true, 1);
            var f3 = new Friend("Bo", "513-322-4544", "bi@gmail.com", false, 1);
            var f4 = new Friend("Bobby", "513-322-4544", "bi@gmail.com", true, 1);
            var f5 = new Friend("Bobbi", "513-322-4544", "bi@gmail.com", false, 1);

            //var friends = new Friend[] { f1, f2, f3, f4, f5 };
             var friends = new List<Friend>();

             friends.Add(f1);
             friends.Add(f2);
             friends.Add(f3);
             friends.Add(f4);
             friends.Add(f5);

            var aFriend = friends[0];

            foreach (var friend in friends)
            {
                 friend.HowLong = (friend.BFF? 10 : 0);
                Console.WriteLine(friend);
            }

            //Create a dictionary
            var StateCodes = new Dictionary<string, string>();
            StateCodes.Add("OH", "Ohio");
            StateCodes.Add("KY", "Kentucky");
            StateCodes.Add("IN", "Indiana");
            var ohio = StateCodes{ "OH"};
        }
        
    }
} 
