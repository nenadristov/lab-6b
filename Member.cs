using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Member
    {
        public string name { get; }
        public int age { get; }
        public int num_borrowed { get;  set; }

        public Member(string name, int age, int num_borrowed=0)
        {
            this.name = name;
            this.age = age;
            this.num_borrowed = num_borrowed;
        }

        public override string ToString()
        {
            Console.WriteLine($"Name: {name}   Age: {age}      Books borrowed: {num_borrowed}\n\n");
            return $"Name: {name}   age: {age}      Books borrowed: {num_borrowed}";
        }

        public void ReturnItem()
        {
            num_borrowed--;
        }
        public void BorrowItem()
        {
            num_borrowed++;
        }
    }
}
