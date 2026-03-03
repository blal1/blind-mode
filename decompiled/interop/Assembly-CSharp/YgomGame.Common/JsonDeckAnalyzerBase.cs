using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C4A")]
public abstract class JsonDeckAnalyzerBase
{
	[Token(Token = "0x6004AE0")]
	[Address(RVA = "0x933580", Offset = "0x932780", VA = "0x180933580")]
	public int GetAccessoryBox(object deckData)
	{
		return default(int);
	}

	[Token(Token = "0x6004AE1")]
	[Address(RVA = "0x9335E0", Offset = "0x9327E0", VA = "0x1809335E0")]
	public int GetAccessorySleeve(object deckData)
	{
		return default(int);
	}

	[Token(Token = "0x6004AE2")]
	[Address(RVA = "0x9336A0", Offset = "0x9328A0", VA = "0x1809336A0")]
	public object GetFocusCards(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE3")]
	[Address(RVA = "0x933700", Offset = "0x932900", VA = "0x180933700")]
	public object GetMainCards(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE4")]
	[Address(RVA = "0x933640", Offset = "0x932840", VA = "0x180933640")]
	public object GetExtraCards(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE5")]
	[Address(RVA = "0x9337C0", Offset = "0x9329C0", VA = "0x1809337C0")]
	public object GetSideCards(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE6")]
	[Address(RVA = "0x933520", Offset = "0x932720", VA = "0x180933520")]
	public Dictionary<string, object> GetAccessories(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE7")]
	[Address(RVA = "0x933760", Offset = "0x932960", VA = "0x180933760")]
	public Dictionary<string, object> GetPickupCards(object deckData)
	{
		return null;
	}

	[Token(Token = "0x6004AE8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected JsonDeckAnalyzerBase()
	{
	}
}
