using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session5_OOPinCSharp
{
    interface IHuman
    {
        string DisplayInfo();
        void InputInfo(int id, string name, int age);
    }
}
