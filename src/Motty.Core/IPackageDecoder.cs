using System;
using System.Collections.Generic;
using System.Text;

namespace Motty.Core
{
    public interface IPackageDecoder<TPackage>
    {
        TPackage Decode(byte[] data);
    }
}
