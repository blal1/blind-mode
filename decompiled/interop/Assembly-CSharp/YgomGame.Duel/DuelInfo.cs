using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017A0")]
public class DuelInfo
{
	[Token(Token = "0x400DD84")]
	[FieldOffset(Offset = "0x10")]
	private SummonMaterialInfo summonMaterialInfo;

	[Token(Token = "0x400DD85")]
	[FieldOffset(Offset = "0x18")]
	private ChainInfo chainInfo;

	[Token(Token = "0x400DD86")]
	[FieldOffset(Offset = "0x20")]
	private SummonEffectInfo summonEffectInfo;

	[Token(Token = "0x60094A9")]
	[Address(RVA = "0xDE4660", Offset = "0xDE3860", VA = "0x180DE4660")]
	public void RecordSummonMaterialType(int uniqueID, SharedDefinition.SummonMaterialType type)
	{
	}

	[Token(Token = "0x60094AA")]
	[Address(RVA = "0xDE4810", Offset = "0xDE3A10", VA = "0x180DE4810")]
	public void ResetSummonMaterialType()
	{
	}

	[Token(Token = "0x60094AB")]
	[Address(RVA = "0xDE3F40", Offset = "0xDE3140", VA = "0x180DE3F40")]
	public bool CheckSummonMaterialType(int uniqueID, SharedDefinition.SummonMaterialType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60094AC")]
	[Address(RVA = "0xDE45C0", Offset = "0xDE37C0", VA = "0x180DE45C0")]
	public bool IsSummonMaterial(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x60094AD")]
	[Address(RVA = "0xDE3E20", Offset = "0xDE3020", VA = "0x180DE3E20")]
	public void AddChainBlockData(int player, int cardID, int uniqueID)
	{
	}

	[Token(Token = "0x60094AE")]
	[Address(RVA = "0xDE43B0", Offset = "0xDE35B0", VA = "0x180DE43B0")]
	public (int, int, int, bool, int) GetCurrentChainBlockData()
	{
		return default((int, int, int, bool, int));
	}

	[Token(Token = "0x60094AF")]
	[Address(RVA = "0xDE4860", Offset = "0xDE3A60", VA = "0x180DE4860")]
	public void SetCurrentChainBlockStep()
	{
	}

	[Token(Token = "0x60094B0")]
	[Address(RVA = "0xDE4720", Offset = "0xDE3920", VA = "0x180DE4720")]
	public void RemoveLastChainData()
	{
	}

	[Token(Token = "0x60094B1")]
	[Address(RVA = "0xDE44C0", Offset = "0xDE36C0", VA = "0x180DE44C0")]
	public int GetCurrentChainNum()
	{
		return default(int);
	}

	[Token(Token = "0x60094B2")]
	[Address(RVA = "0xDE48D0", Offset = "0xDE3AD0", VA = "0x180DE48D0")]
	public void SetLastCardHappenEffectNo(int effectNo)
	{
	}

	[Token(Token = "0x60094B3")]
	[Address(RVA = "0xDE4040", Offset = "0xDE3240", VA = "0x180DE4040")]
	public List<int> GetChainInfo(int player)
	{
		return null;
	}

	[Token(Token = "0x60094B4")]
	[Address(RVA = "0xDE4990", Offset = "0xDE3B90", VA = "0x180DE4990")]
	public void SetSummonTargetUniqueID(int[] uniqueIDs)
	{
	}

	[Token(Token = "0x60094B5")]
	[Address(RVA = "0xDE48F0", Offset = "0xDE3AF0", VA = "0x180DE48F0")]
	public void SetSummonTargetUniqueID(int uniqueID)
	{
	}

	[Token(Token = "0x60094B6")]
	[Address(RVA = "0xDE3FF0", Offset = "0xDE31F0", VA = "0x180DE3FF0")]
	public void ClearSummonTargetUniqueID()
	{
	}

	[Token(Token = "0x60094B7")]
	[Address(RVA = "0xDE4790", Offset = "0xDE3990", VA = "0x180DE4790")]
	public void RemoveSummonTargetUniqueID(int uniqueID)
	{
	}

	[Token(Token = "0x60094B8")]
	[Address(RVA = "0xDE4560", Offset = "0xDE3760", VA = "0x180DE4560")]
	public bool IsContains(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x60094B9")]
	[Address(RVA = "0xDE4510", Offset = "0xDE3710", VA = "0x180DE4510")]
	public int GetSummonTargetCount()
	{
		return default(int);
	}

	[Token(Token = "0x60094BA")]
	[Address(RVA = "0xDE49F0", Offset = "0xDE3BF0", VA = "0x180DE49F0")]
	public DuelInfo()
	{
	}
}
