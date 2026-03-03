using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x2000701")]
public class OnDemandLogoOrder
{
	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x10")]
	private List<OnDemandLogoData> m_logoList;

	[Token(Token = "0x170005B9")]
	public List<OnDemandLogoData> logoList
	{
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BA")]
	public bool isEmpty
	{
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x71D600", Offset = "0x71C800", VA = "0x18071D600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	private OnDemandLogoOrder()
	{
	}

	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x71D650", Offset = "0x71C850", VA = "0x18071D650")]
	private void initialize()
	{
	}

	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x71D680", Offset = "0x71C880", VA = "0x18071D680")]
	private static List<OnDemandLogoData> readFromCleintWork()
	{
		return null;
	}

	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x71D590", Offset = "0x71C790", VA = "0x18071D590")]
	public static OnDemandLogoOrder GetFromClientWork()
	{
		return null;
	}
}
