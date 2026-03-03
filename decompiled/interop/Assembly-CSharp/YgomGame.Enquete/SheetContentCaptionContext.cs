using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE2")]
public class SheetContentCaptionContext : SheetContentContextBase
{
	[Token(Token = "0x400A10B")]
	[FieldOffset(Offset = "0x28")]
	public readonly GlobalTextData text;

	[Token(Token = "0x17000C45")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053AE")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x60053AF")]
	[Address(RVA = "0x9A95C0", Offset = "0x9A87C0", VA = "0x1809A95C0")]
	public SheetContentCaptionContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053B0")]
	[Address(RVA = "0x9A9510", Offset = "0x9A8710", VA = "0x1809A9510")]
	public SheetContentCaptionContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053B1")]
	[Address(RVA = "0x9A93F0", Offset = "0x9A85F0", VA = "0x1809A93F0", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053B2")]
	[Address(RVA = "0x9A9490", Offset = "0x9A8690", VA = "0x1809A9490", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
