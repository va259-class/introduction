using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Interfaces.Abstractions
{
    internal interface ISpeakable
    {
        public void Speak(string thingsToSpeak);
        public string SayHi();
    }

    internal interface IRunnable
    {
    }

    internal interface IFlyable
    {
    }

    internal interface IAlive
    {
    }
}
