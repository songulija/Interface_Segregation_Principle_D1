using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //this interface is for specifically Borrowable Audio book. it inherits from two interfaces
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}
