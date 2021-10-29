using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motty.Core
{
    public interface IChannel
    {
        void Start();
        void Stop();
        void Send(byte[] data);
        Task SendAsync(byte[] data);
        event Action<byte[]> ReceiveData;
    }
}
