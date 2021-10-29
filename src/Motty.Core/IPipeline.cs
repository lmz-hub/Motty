using System;
using System.Collections.Generic;
using System.Text;

namespace Motty.Core
{
    public interface IPipelineFilter<TReceivePackage>
    {
        IPackageDecoder<TReceivePackage> Decoder { get; set; }
        TReceivePackage Filter(byte[] data);
    }
}
