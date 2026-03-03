using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DEB")]
public class SheetContentInputTextConfirmContext : SheetContentContextBase
{
	[Token(Token = "0x400A126")]
	[FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x17000C57")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x577DA0", Offset = "0x576FA0", VA = "0x180577DA0", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x60053DE")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public SheetContentInputTextConfirmContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053DF")]
	[Address(RVA = "0x9A9AB0", Offset = "0x9A8CB0", VA = "0x1809A9AB0")]
	public SheetContentInputTextConfirmContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053E0")]
	[Address(RVA = "0x9AAD80", Offset = "0x9A9F80", VA = "0x1809AAD80")]
	public SheetContentInputTextConfirmContext Copy()
	{
		return null;
	}

	[Token(Token = "0x60053E1")]
	[Address(RVA = "0x9AAE10", Offset = "0x9AA010", VA = "0x1809AAE10", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053E2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
