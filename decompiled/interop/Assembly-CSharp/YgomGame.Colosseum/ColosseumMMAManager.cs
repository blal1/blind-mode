using Il2CppDummyDll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001D2E")]
public class ColosseumMMAManager
{
	[Token(Token = "0x4010239")]
	private const string basePath = "MDMarkupAsset/Colosseum/Common/MDMarkupCommon_";

	[Token(Token = "0x600BB83")]
	[Address(RVA = "0x5722C0", Offset = "0x5714C0", VA = "0x1805722C0")]
	public static void OpenMMA(ColosseumUtil.PlayMode mode, string param = "")
	{
	}

	[Token(Token = "0x600BB84")]
	[Address(RVA = "0x5720C0", Offset = "0x5712C0", VA = "0x1805720C0")]
	private static string GetPath(ColosseumUtil.PlayMode mode)
	{
		return null;
	}

	[Token(Token = "0x600BB85")]
	[Address(RVA = "0x572110", Offset = "0x571310", VA = "0x180572110")]
	public static void OpenMMA_Versus(int eventId, int logoId, string serverMMAPath = "")
	{
	}

	[Token(Token = "0x600BB86")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ColosseumMMAManager()
	{
	}
}
