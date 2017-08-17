using System.Net;
using System.Net.Sockets;

namespace NET.Class.Socks
{
    class SocketFOSC
    {
        #region Vars
        private Socket _Socket;
        private NetworkStream _NetStream;
        private IPEndPoint _IPEP;
        private EndPoint _EP;
        private int _PORT = 0;
        #endregion

        #region Public Methods
        public SocketFOSC(Socket usedSck, int usedPort)
        {
            _PORT = usedPort;
            try
            {
                _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                _IPEP = new IPEndPoint(IPAddress.Any, _PORT);
                _Socket.Bind(_IPEP);
                _EP = (EndPoint)_IPEP;


            }
            catch(SocketException scke)
            {
                throw scke;
            }
            finally
            {
                _PORT = 0;
            }
        }
        #endregion
    }
}
