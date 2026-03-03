using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Common;

[Token(Token = "0x2000C54")]
public class JsonStructureMasterAnalyzer : JsonDeckAnalyzerBase
{
	[Token(Token = "0x6004AFE")]
	[Address(RVA = "0x9342A0", Offset = "0x9334A0", VA = "0x1809342A0")]
	public int GetStructureId(object structureMaster)
	{
		return default(int);
	}

	[Token(Token = "0x6004AFF")]
	[Address(RVA = "0x934220", Offset = "0x933420", VA = "0x180934220")]
	public string GetName(object structureMaster, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x6004B00")]
	[Address(RVA = "0x9341A0", Offset = "0x9333A0", VA = "0x1809341A0")]
	public string GetDesc(object structureMaster, bool useMobileSfx = false)
	{
		return null;
	}

	[Token(Token = "0x6004B01")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public JsonStructureMasterAnalyzer()
	{
	}
}
