using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public enum Classification
    {
        Universal,
        Youth,
        Adult
    }


    // A DVD is a kind of item.
    class DVD : Item
    {
        // Instance variables.
        private int Time { get; set; }
        private Classification classification { get; set; }

        public DVD(string title, int time, Classification classification)
             : base(title)
        {
            this.Time = time;
            this.classification = classification;
        }

        // Constructor.
        

        public bool Can_be_borrowed(Member name)
        {
            if (classification == Classification.Adult && name.age >= 18)
            {
                Console.WriteLine("The DVD can be borrowed");
                return true;
            }
            else if (classification == Classification.Youth && name.age >= 12)
            {

                Console.WriteLine("The DVD can be borrowed");
                return true;
            }
            else
            if(classification == Classification.Universal)
            {
                Console.WriteLine("The DVD can be borrowed");
                return true;
            }
            else
            {
                Console.WriteLine("The DVD can NOT be borrowed");
                return false;
            }
           

        }

        public override string ToString()
        {
            return $"{base.ToString()}\n  Additional DVD details: {Time} {classification}.";
        }

        
        
    }
}
