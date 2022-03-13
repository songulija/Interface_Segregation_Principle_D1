using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{   //inherits from two other interfaces. For Borrowable DVD
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
