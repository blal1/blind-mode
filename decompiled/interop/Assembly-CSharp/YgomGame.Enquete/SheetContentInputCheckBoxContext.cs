using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE9")]
public class SheetContentInputCheckBoxContext : SheetContentContextBase
{
	[Token(Token = "0x2000DEA")]
	public class ContentContext : ContextBase
	{
		[Token(Token = "0x400A125")]
		[FieldOffset(Offset = "0x18")]
		public readonly GlobalTextData text;

		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x99DC80", Offset = "0x99CE80", VA = "0x18099DC80")]
		public ContentContext()
		{
		}

		[Token(Token = "0x60053DA")]
		[Address(RVA = "0x99DCF0", Offset = "0x99CEF0", VA = "0x18099DCF0")]
		public ContentContext(object jsonData)
		{
		}

		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x99DB60", Offset = "0x99CD60", VA = "0x18099DB60", Slot = "7")]
		public override void Import(object jsonData)
		{
		}

		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x99DC00", Offset = "0x99CE00", VA = "0x18099DC00", Slot = "9")]
		public override void SearchDependencieTextGroups(List<string> resultList)
		{
		}
	}

	[Token(Token = "0x400A122")]
	[FieldOffset(Offset = "0x28")]
	public readonly List<ContentContext> contents;

	[Token(Token = "0x400A123")]
	[FieldOffset(Offset = "0x30")]
	public int min;

	[Token(Token = "0x400A124")]
	[FieldOffset(Offset = "0x34")]
	public int max;

	[Token(Token = "0x17000C55")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x443230", Offset = "0x442430", VA = "0x180443230", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x17000C56")]
	public override bool isInput
	{
		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053D6")]
	[Address(RVA = "0x9AACB0", Offset = "0x9A9EB0", VA = "0x1809AACB0")]
	public SheetContentInputCheckBoxContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053D7")]
	[Address(RVA = "0x9AA850", Offset = "0x9A9A50", VA = "0x1809AA850", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053D8")]
	[Address(RVA = "0x9AAB90", Offset = "0x9A9D90", VA = "0x1809AAB90", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
