using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motty.Core
{
    public class BaseClient<TSendPackage,TReceivePackage> : IClient<TSendPackage,TReceivePackage>
    {
        public BaseClient()
        {

        }
        /// <summary>
        /// 发送接收数据通道
        /// </summary>
        private IChannel _channel;
        /// <summary>
        /// 数据编码器
        /// </summary>
        private IPackageEncoder<TSendPackage> _encoder;
        /// <summary>
        /// 筛选数据处理
        /// </summary>
        private IPipelineFilter<TReceivePackage> _pipeline;
        /// <summary>
        /// 数据包处理
        /// </summary>
        public event Action<TReceivePackage> PackageHandler;
        /// <summary>
        /// 断开连接
        /// </summary>
        public event EventHandler DisConnected;

        public void Connect()
        {
            _channel.Start();
            _channel.ReceiveData += ReceiveFromChannel;
        }

        private void ReceiveFromChannel(byte[] data)
        {
            var package = _pipeline.Filter(data);

        }

        private void StartReceive()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    
                }
            }, TaskCreationOptions.LongRunning);
        }

        public Task ConnectAsync()
        {
            throw new NotImplementedException();
        }

        public void DisConnect()
        {
            _channel.Stop();
        }

        public Task DisConnectAsync()
        {
            throw new NotImplementedException();
        }
        public Task<TReceivePackage> ReceiveTAP()
        {
            throw new NotImplementedException();
        }

        public void SendEAP(byte[] data)
        {
            
        }


        public Task SendTAP(byte[] data)
        {
            throw new NotImplementedException();
        }


        public void SendEAP(TSendPackage package)
        {
            
            
        }

        public Task SendTAP(TSendPackage package)
        {
            throw new NotImplementedException();
        }
    }
}
