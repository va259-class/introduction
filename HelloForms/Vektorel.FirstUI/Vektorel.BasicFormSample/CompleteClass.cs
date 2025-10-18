using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.BasicFormSample
{
    partial class CompleteClass
    {
        void A()
        {
            B();
        }
    }
}

namespace Vektorel.BasicFormSample
{
    partial class CompleteClass
    {
        void B()
        {
            A();
        }
    }
}
