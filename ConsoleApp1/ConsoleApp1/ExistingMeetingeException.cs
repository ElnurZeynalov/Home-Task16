using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ExistingMeetingeException:Exception
    {
        public ExistingMeetingeException(string msg) : base(msg)
        {
        }
    }
}
