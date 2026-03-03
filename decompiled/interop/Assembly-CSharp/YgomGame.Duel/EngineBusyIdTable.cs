using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B72")]
public class EngineBusyIdTable
{
	[Token(Token = "0x400F8EF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<Engine.ViewType, Engine.ViewType> tbl;

	[Token(Token = "0x17001AF3")]
	public static Dictionary<Engine.ViewType, Engine.ViewType> table
	{
		[Token(Token = "0x600B104")]
		[Address(RVA = "0x487E10", Offset = "0x487010", VA = "0x180487E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B105")]
	[Address(RVA = "0x4875A0", Offset = "0x4867A0", VA = "0x1804875A0")]
	public static Engine.ViewType GetBusyEffectId(Engine.ViewType runEffectId)
	{
		return default(Engine.ViewType);
	}

	[Token(Token = "0x600B106")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public EngineBusyIdTable()
	{
	}
}
