using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomDebug;

[Token(Token = "0x2000132")]
public class LogShowChainForAnalysis : LogItemBaseForAnalysis
{
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x20")]
	protected string LABEL_EO_CHAINNUM;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x28")]
	protected string LABEL_EO_CHAINTEXT;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x30")]
	protected string LABEL_EO_MINICARD;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x0")]
	protected static Dictionary<ShowChainDataForAnalysis.ChainDataTypeForAnalysis, string> m_ChainLabelDict;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170000D7")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x9D9910", Offset = "0x9D8B10", VA = "0x1809D9910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x9D9620", Offset = "0x9D8820", VA = "0x1809D9620")]
	public void SetData(ShowChainDataForAnalysis data)
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x9D94E0", Offset = "0x9D86E0", VA = "0x1809D94E0")]
	public static void ResetWordTable()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x9D9870", Offset = "0x9D8A70", VA = "0x1809D9870")]
	public LogShowChainForAnalysis()
	{
	}
}
