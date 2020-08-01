using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating Member object
            Member[] members = new Member[10];
            members[0] = new Member("John", 33);
            members[1] = new Member("Jane", 22);
            members[2] = new Member("Donny", 22);

            //declearing an array
            Item[] items = new Item[6];


            //creating Book objects
            items[0] = new Book("The Bourne identity", "Robert Ludlum", "2342341235346346", Genre.Fiction);
            items[1] = new Book("Zoki Poki", "Olivera Nikolova", "2342341235346346", Genre.Children);
            items[2] = new Book("Animal Farm", "George Orwell", "2342341235346346", Genre.NonFiction);
            // adding book into the array


            //creating DVD objects
            items[3] = new DVD("Jason Bourne", 120, Classification.Adult);
            items[4] = new DVD("Kissing booth", 160, Classification.Youth);
            items[5] = new DVD("Home Alone", 160, Classification.Universal);

            //adding to interfac array
            IReservable[] Ireserve = new IReservable[6];
            int pos = 0;
            for (int i = 0; i < items.Length; i++)
            {
                Item item = (Item)items[i];
                if (item is IReservable)
                {
                    Ireserve[pos++] = (IReservable)item;
                }
            } 

            //trying to borrow reserved item
            
            bool result = Ireserve[0].Reserved_for(members[0]);
            Console.WriteLine($"Can we reserve a ReservableBook that isn't yet borrowed? {result}");



            items[0].Borrow_item_by(members[1]);
            Console.WriteLine($"{items[0]} has just been borrowed");


            //checking if members can borrow items
            bool result1=items[0].Can_be_borrowed_by(members[0]);
            if (result1 == true)
                items[0].Borrow_item_by(members[0]);
            Console.WriteLine("\n\n");

            bool result2 = items[2].Can_be_borrowed_by(members[2]);
            if (result2 == true)
                items[2].Borrow_item_by(members[2]);
            Console.WriteLine("\n\n");

            bool result3 = items[4].Can_be_borrowed_by(members[0]);
            if (result3 == true)
                items[4].Borrow_item_by(members[0]);
            

            //member 0
            Console.WriteLine("_____________________________");
            members[0].ToString();
            items[0].Return_item(members[0]);
            members[0].ToString();
            Console.WriteLine("_____________________________");

            //member 2
            
            members[2].ToString();
            items[2].Return_item(members[2]);
            members[2].ToString();

            
            
            Console.ReadLine();
        }
    }
}

