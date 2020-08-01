using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    abstract class Item
    {
        public string title { get; set; }
        
        public string date_borrowed { get; set; }
        public string borrower_name { get; set; }

        public Item(string title, string date_borrowed = null, string borrower_name = null)
        {
            this.title = title;
            this.date_borrowed = date_borrowed;
            this.borrower_name = borrower_name;
        }

        public bool Borrowed()
        {
            if (borrower_name == null)
                return true;
            else
                return false;
        }

        public bool Can_be_borrowed_by(Member name)
        {
            if (name.num_borrowed >= 1)
            {
                //Console.WriteLine("The item can  NOT be borrowed");
                return false;
            }

            else
            {
                //Console.WriteLine("The item can  be borrowed");
                return true;
            }
               
        }

        public bool Borrow_item_by(Member name)
        {
            if (borrower_name == null)
            {
                if (Can_be_borrowed_by(name) == true)
                {
                    Console.WriteLine($"The item has been successfully borrowed to {name.name}");
                    name.BorrowItem();
                    return true;
                }
                else
                {
                    Console.WriteLine($"The item can't be borrowed to {name.name}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("The item has not been successfully borrowed");
                return false;
            }
        
        }

        public void Return_item(Member name)//problem
        {
            name.ReturnItem();
            borrower_name = null;
            Console.WriteLine("The item has been successfully returned");
        }

        public override string ToString()
        {
            if (borrower_name != null)
            {
                return $"{title} is on loan to {borrower_name}.";
            }
            else
            {
                return $"{title} is not on loan.";
            }
            
        }

    }
}
