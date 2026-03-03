using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DEC")]
public class SheetContentInputTextContext : SheetContentContextBase
{
	[Token(Token = "0x400A127")]
	[FieldOffset(Offset = "0x28")]
	public int limit;

	[Token(Token = "0x17000C58")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x17000C59")]
	public override bool isInput
	{
		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053E5")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public SheetContentInputTextContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053E6")]
	[Address(RVA = "0x9A9AB0", Offset = "0x9A8CB0", VA = "0x1809A9AB0")]
	public SheetContentInputTextContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053E7")]
	[Address(RVA = "0x9AAF80", Offset = "0x9AA180", VA = "0x1809AAF80")]
	public SheetContentInputTextContext Copy()
	{
		return null;
	}

	[Token(Token = "0x60053E8")]
	[Address(RVA = "0x9AAEB0", Offset = "0x9AA0B0", VA = "0x1809AAEB0", Slot = "8")]
	public override void CopyTo(ContextBase target)
	{
	}

	[Token(Token = "0x60053E9")]
	[Address(RVA = "0x9AB010", Offset = "0x9AA210", VA = "0x1809AB010", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053EA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
