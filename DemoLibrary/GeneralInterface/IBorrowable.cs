using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// interface that will define methods and props specifically on borrowable books
    /// </summary>
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        //thats for book but not for DVD,referenceBook


        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
