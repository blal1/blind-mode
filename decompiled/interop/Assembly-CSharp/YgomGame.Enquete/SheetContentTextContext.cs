using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DEE")]
public class SheetContentTextContext : SheetContentContextBase
{
	[Token(Token = "0x400A128")]
	[FieldOffset(Offset = "0x28")]
	public readonly GlobalTextData text;

	[Token(Token = "0x400A129")]
	[FieldOffset(Offset = "0x30")]
	public bool isLabel;

	[Token(Token = "0x17000C5B")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x60053F1")]
	[Address(RVA = "0x9AB2A0", Offset = "0x9AA4A0", VA = "0x1809AB2A0")]
	public SheetContentTextContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053F2")]
	[Address(RVA = "0x9AB1F0", Offset = "0x9AA3F0", VA = "0x1809AB1F0")]
	public SheetContentTextContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053F3")]
	[Address(RVA = "0x9AB0A0", Offset = "0x9AA2A0", VA = "0x1809AB0A0", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053F4")]
	[Address(RVA = "0x9AB170", Offset = "0x9AA370", VA = "0x1809AB170", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
