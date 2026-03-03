using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Market;

[Token(Token = "0x2000D29")]
public static class MarketUtil
{
	[Token(Token = "0x4009DA7")]
	private const string k_MarketMMAPathPrefix = "Help/MMA/Market/MMAMarket";

	[Token(Token = "0x4009DA8")]
	private const string k_PortalMMAPathFormat = "Help/MMA/Market/MMAMarketPortal?mid={0}&shopId={1}&popOnSubmit={2}";

	[Token(Token = "0x6004F4B")]
	[Address(RVA = "0x977A90", Offset = "0x976C90", VA = "0x180977A90")]
	public static void OpenMarketPortal(int marketId, int shopId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004F4C")]
	[Address(RVA = "0x9778A0", Offset = "0x976AA0", VA = "0x1809778A0")]
	public static void OpenMarketPortal(int marketId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004F4D")]
	[Address(RVA = "0x977280", Offset = "0x976480", VA = "0x180977280")]
	public static void AbortMarket()
	{
	}

	[Token(Token = "0x6004F4E")]
	[Address(RVA = "0x977710", Offset = "0x976910", VA = "0x180977710")]
	private static ViewController FindFirstMarketVc()
	{
		return null;
	}

	[Token(Token = "0x6004F4F")]
	[Address(RVA = "0x977450", Offset = "0x976650", VA = "0x180977450")]
	public static bool CheckHandleNetworkError(Handle handle)
	{
		return default(bool);
	}
}
