using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DebuggingFriendsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelic" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list", "The list is empty");


            if(count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than elements in the list or less than one");
            }

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
                return shortestName;
            }
        }
    }

