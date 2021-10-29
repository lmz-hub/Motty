using System;
using System.Collections.Generic;
using System.Text;

namespace Motty.Core
{
    public interface IByteBuffer
    {
        int ReadIndex { get; }
        int WriteIndex { get; }
        

    }
}
