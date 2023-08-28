using System.Net.NetworkInformation;

namespace GerenciadorDeAcervos.Data
{
    public class CheckConnection
    {
        public static bool Connection()
        {
            return NetworkInterface.GetIsNetworkAvailable() ? true : false;
        }
    }
}
