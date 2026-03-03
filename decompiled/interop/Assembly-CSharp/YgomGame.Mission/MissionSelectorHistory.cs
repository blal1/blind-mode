using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Mission;

[Token(Token = "0x2000C00")]
public class MissionSelectorHistory
{
	[Token(Token = "0x400997C")]
	[FieldOffset(Offset = "0x10")]
	private List<IMissionSelectorHistoryHandler> m_Handlers;

	[Token(Token = "0x6004919")]
	[Address(RVA = "0x923900", Offset = "0x922B00", VA = "0x180923900")]
	public void Assign(IMissionSelectorHistoryHandler handler)
	{
	}

	[Token(Token = "0x600491A")]
	[Address(RVA = "0x9239B0", Offset = "0x922BB0", VA = "0x1809239B0")]
	public void Save()
	{
	}

	[Token(Token = "0x600491B")]
	[Address(RVA = "0x923BD0", Offset = "0x922DD0", VA = "0x180923BD0")]
	public bool TrySelect()
	{
		return default(bool);
	}

	[Token(Token = "0x600491C")]
	[Address(RVA = "0x923E90", Offset = "0x923090", VA = "0x180923E90")]
	public MissionSelectorHistory()
	{
	}
}
