using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DED")]
public class SheetContentSpacerContext : SheetContentContextBase
{
	[Token(Token = "0x17000C5A")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x60053EC")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public SheetContentSpacerContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053ED")]
	[Address(RVA = "0x9A9AB0", Offset = "0x9A8CB0", VA = "0x1809A9AB0")]
	public SheetContentSpacerContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053EE")]
	[Address(RVA = "0x9AB090", Offset = "0x9AA290", VA = "0x1809AB090", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053EF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
