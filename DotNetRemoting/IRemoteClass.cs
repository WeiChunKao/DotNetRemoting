using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteClass
{
    public interface IRemoteClass:IDisposable
    {
        int Add(int a, int b);
        int Multy(int a, int b);
        int Divide(int a, int b);
        int Substract(int a, int b);
    }
}
