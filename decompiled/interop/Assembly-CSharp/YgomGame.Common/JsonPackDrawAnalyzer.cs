using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Common;

[Token(Token = "0x2000C4E")]
public class JsonPackDrawAnalyzer : JsonObjectAanalyzerBase
{
	[Token(Token = "0x6004AEE")]
	[Address(RVA = "0x933CF0", Offset = "0x932EF0", VA = "0x180933CF0")]
	public int GetMrk(object drawData)
	{
		return default(int);
	}

	[Token(Token = "0x6004AEF")]
	[Address(RVA = "0x933D50", Offset = "0x932F50", VA = "0x180933D50")]
	public int GetPremium(object drawData)
	{
		return default(int);
	}

	[Token(Token = "0x6004AF0")]
	[Address(RVA = "0x933EB0", Offset = "0x9330B0", VA = "0x180933EB0")]
	public bool IsNew(object drawData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF1")]
	[Address(RVA = "0x933A50", Offset = "0x932C50", VA = "0x180933A50")]
	public CardCollectionInfo.Rarity BackSideRarity(object drawData)
	{
		return default(CardCollectionInfo.Rarity);
	}

	[Token(Token = "0x6004AF2")]
	[Address(RVA = "0x933BD0", Offset = "0x932DD0", VA = "0x180933BD0")]
	public int[] GetFoundedSecrets(object drawData)
	{
		return null;
	}

	[Token(Token = "0x6004AF3")]
	[Address(RVA = "0x933E30", Offset = "0x933030", VA = "0x180933E30")]
	public bool IsFoundedSecrets(object drawData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF4")]
	[Address(RVA = "0x933AB0", Offset = "0x932CB0", VA = "0x180933AB0")]
	public int[] GetExtendedSecrets(object drawData)
	{
		return null;
	}

	[Token(Token = "0x6004AF5")]
	[Address(RVA = "0x933DB0", Offset = "0x932FB0", VA = "0x180933DB0")]
	public bool IsExtendedSecrets(object drawData)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AF6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public JsonPackDrawAnalyzer()
	{
	}
}
