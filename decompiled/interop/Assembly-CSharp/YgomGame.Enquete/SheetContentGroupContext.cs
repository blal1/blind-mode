using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE6")]
public class SheetContentGroupContext : SheetContentContextBase
{
	[Token(Token = "0x400A11A")]
	[FieldOffset(Offset = "0x30")]
	public readonly List<ISheetContentContext> contents;

	[Token(Token = "0x17000C4E")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x17000C4F")]
	public bool isMust
	{
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000C50")]
	public override bool isInput
	{
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x9AA080", Offset = "0x9A9280", VA = "0x1809AA080", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053C3")]
	[Address(RVA = "0x9A9F20", Offset = "0x9A9120", VA = "0x1809A9F20")]
	public SheetContentGroupContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053C4")]
	[Address(RVA = "0x9A9FC0", Offset = "0x9A91C0", VA = "0x1809A9FC0")]
	public SheetContentGroupContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053C6")]
	[Address(RVA = "0x9A9B10", Offset = "0x9A8D10", VA = "0x1809A9B10", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053C7")]
	[Address(RVA = "0x9A9D60", Offset = "0x9A8F60", VA = "0x1809A9D60", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
