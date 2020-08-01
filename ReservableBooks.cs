using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class ReservableBooks : Book, IReservable
    {
        private Member reserver;

        public ReservableBooks(string title, string author, string isbn, Genre genre)
            : base(title, author, isbn, genre)
        {
        }
        public bool Reserved()
        {
            return reserver != null; 
        }

        public bool Can_be_reserved_for(Member member)
        {
            return Can_be_borrowed_by(member);
        }

        public bool Reserved_for(Member member)
        {
            // Is the item currently borrowed (and not already reserved), and is the specified member allowed to reserve it?
            if (Borrowed() && !Reserved() && Can_be_reserved_for(member))
            {
                reserver = member;
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
