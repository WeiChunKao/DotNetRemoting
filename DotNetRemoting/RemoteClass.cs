using RemoteClass;
using System;

namespace DotNetRemoting
{
    public class RemoteClass : MarshalByRefObject, IRemoteClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new Exception("Can't divid Zero");
            return a / b;
        }

        public int Multy(int a, int b)
        {
            return a * b; 
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
