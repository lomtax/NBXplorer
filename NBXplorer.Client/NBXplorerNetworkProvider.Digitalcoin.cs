using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitDigitalcoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Digitalcoin.Instance, networkType)
			{
				MinRPCVersion = 120000
			});
		}

		public NBXplorerNetwork GetDGC()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Digitalcoin.Instance.CryptoCode);
		}
	}
}
