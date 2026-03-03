using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20017A2")]
internal class SummonMaterialInfo
{
	[Token(Token = "0x400DD89")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, SharedDefinition.SummonMaterialType> summonMaterialType;

	[Token(Token = "0x60094BD")]
	[Address(RVA = "0xDEE690", Offset = "0xDED890", VA = "0x180DEE690")]
	public void RecordSummonMaterialType(int uniqueID, SharedDefinition.SummonMaterialType type)
	{
	}

	[Token(Token = "0x60094BE")]
	[Address(RVA = "0xDEE740", Offset = "0xDED940", VA = "0x180DEE740")]
	public void ResetSummonMaterialType()
	{
	}

	[Token(Token = "0x60094BF")]
	[Address(RVA = "0xDEE550", Offset = "0xDED750", VA = "0x180DEE550")]
	public bool CheckSummonMaterialType(int uniqueID, SharedDefinition.SummonMaterialType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60094C0")]
	[Address(RVA = "0xDEE600", Offset = "0xDED800", VA = "0x180DEE600")]
	public bool IsSummonMaterial(int uniqueID)
	{
		return default(bool);
	}

	[Token(Token = "0x60094C1")]
	[Address(RVA = "0xDEE790", Offset = "0xDED990", VA = "0x180DEE790")]
	public SummonMaterialInfo()
	{
	}
}
