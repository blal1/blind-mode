using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x200190B")]
public class LogShowChain : LogItemBase
{
	[Token(Token = "0x400EA5C")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_CHAINNUM;

	[Token(Token = "0x400EA5D")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_CHAINTEXT;

	[Token(Token = "0x400EA5E")]
	[FieldOffset(Offset = "0x60")]
	protected string LABEL_EO_MINICARD;

	[Token(Token = "0x400EA5F")]
	[FieldOffset(Offset = "0x0")]
	protected static Dictionary<ShowChainData.ChainDataType, string> m_ChainLabelDict;

	[Token(Token = "0x400EA60")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B5")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A199")]
		[Address(RVA = "0xEF3260", Offset = "0xEF2460", VA = "0x180EF3260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A197")]
	[Address(RVA = "0xEF2C60", Offset = "0xEF1E60", VA = "0x180EF2C60")]
	public void SetData(ShowChainData data)
	{
	}

	[Token(Token = "0x600A198")]
	[Address(RVA = "0xEF2B20", Offset = "0xEF1D20", VA = "0x180EF2B20")]
	public static void ResetWordTable()
	{
	}

	[Token(Token = "0x600A19A")]
	[Address(RVA = "0xEF31C0", Offset = "0xEF23C0", VA = "0x180EF31C0")]
	public LogShowChain()
	{
	}
}
