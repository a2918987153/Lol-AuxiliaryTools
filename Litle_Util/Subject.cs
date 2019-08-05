using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Litle_Util
{
    public interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }
}
