using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE1")]
public class RootContext : ContextBase
{
	[Token(Token = "0x400A108")]
	[FieldOffset(Offset = "0x18")]
	public readonly GlobalTextData title;

	[Token(Token = "0x400A109")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<SheetContext> sheets;

	[Token(Token = "0x400A10A")]
	[FieldOffset(Offset = "0x28")]
	public bool isGuideMust;

	[Token(Token = "0x60053AB")]
	[Address(RVA = "0x9A8E30", Offset = "0x9A8030", VA = "0x1809A8E30", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053AC")]
	[Address(RVA = "0x9A91A0", Offset = "0x9A83A0", VA = "0x1809A91A0", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}

	[Token(Token = "0x60053AD")]
	[Address(RVA = "0x9A9340", Offset = "0x9A8540", VA = "0x1809A9340")]
	public RootContext()
	{
	}
}
