using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //this interface inherits from IBorrowable and IBook interfaces methods and props
    //it joins two interfaces
    public interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
