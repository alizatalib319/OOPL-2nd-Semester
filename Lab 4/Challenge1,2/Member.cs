using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_CHALLENGE_1
{
    internal class Member
    {
        public string name;
        public int id;
        public Member(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Member(string name)
        {
            this.name = name;
        }
        public void showData()
        {
            Console.WriteLine($"Name: {name}");
            if(id!=0)
            {
                Console.WriteLine($"ID: {id}");
            }
        }
    }
}
