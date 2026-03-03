using Il2CppDummyDll;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005DF")]
public class CurrentMultiVCTabData
{
	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x10")]
	public int tabIndex;

	[Token(Token = "0x4001C19")]
	[FieldOffset(Offset = "0x14")]
	public int tabGroupId;

	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x18")]
	public int sectionTabIndex;

	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x1C")]
	public int sectionTabGruopId;

	[Token(Token = "0x4001C1C")]
	[FieldOffset(Offset = "0x20")]
	public int horizonTabIndex;

	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x24")]
	public int horizonTabGroupId;

	[Token(Token = "0x6002665")]
	[Address(RVA = "0x689740", Offset = "0x688940", VA = "0x180689740")]
	public CurrentMultiVCTabData Clone()
	{
		return null;
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CurrentMultiVCTabData()
	{
	}
}
