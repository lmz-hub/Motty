using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motty.Core
{
    public interface IClient<TSendPackage,TReceivePackage>
    {
        void Connect();
        Task ConnectAsync();
        void DisConnect();
        Task DisConnectAsync();
        void SendEAP(byte[] data);
        void SendEAP(TSendPackage package);
        Task SendTAP(byte[] data);
        Task SendTAP(TSendPackage package);
        Task<TReceivePackage> ReceiveTAP();

        event Action<TReceivePackage> PackageHandler;
        event EventHandler DisConnected;
    }
}
