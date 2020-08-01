using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    interface IReservable
    {
        bool Reserved();

        bool Can_be_reserved_for(Member name);

        bool Reserved_for(Member name);


    }
}
