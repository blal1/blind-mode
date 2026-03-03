using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DEF")]
public class SheetContext : ContextBase
{
	[Token(Token = "0x400A12A")]
	[FieldOffset(Offset = "0x18")]
	public readonly List<ISheetContentContext> contents;

	[Token(Token = "0x400A12B")]
	[FieldOffset(Offset = "0x20")]
	public readonly RootContext rootContext;

	[Token(Token = "0x60053F5")]
	[Address(RVA = "0x9ABAF0", Offset = "0x9AACF0", VA = "0x1809ABAF0")]
	public SheetContext()
	{
	}

	[Token(Token = "0x60053F6")]
	[Address(RVA = "0x9ABA30", Offset = "0x9AAC30", VA = "0x1809ABA30")]
	public SheetContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053F7")]
	[Address(RVA = "0x9AB490", Offset = "0x9AA690", VA = "0x1809AB490", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053F8")]
	[Address(RVA = "0x9AB870", Offset = "0x9AAA70", VA = "0x1809AB870", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}

	[Token(Token = "0x60053F9")]
	[Address(RVA = "0x9AB330", Offset = "0x9AA530", VA = "0x1809AB330")]
	public bool ContainsMust()
	{
		return default(bool);
	}
}
