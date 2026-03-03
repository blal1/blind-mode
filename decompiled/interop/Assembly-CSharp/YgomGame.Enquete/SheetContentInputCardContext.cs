using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE8")]
public class SheetContentInputCardContext : SheetContentContextBase
{
	[Token(Token = "0x400A11E")]
	[FieldOffset(Offset = "0x28")]
	public readonly GlobalTextData text;

	[Token(Token = "0x400A11F")]
	[FieldOffset(Offset = "0x30")]
	public int min;

	[Token(Token = "0x400A120")]
	[FieldOffset(Offset = "0x34")]
	public int max;

	[Token(Token = "0x400A121")]
	[FieldOffset(Offset = "0x38")]
	public int cardpoolId;

	[Token(Token = "0x17000C53")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053CD")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x17000C54")]
	public override bool isInput
	{
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053CF")]
	[Address(RVA = "0x9AA6F0", Offset = "0x9A98F0", VA = "0x1809AA6F0")]
	public SheetContentInputCardContext(RootContext rootContext)
	{
	}

	[Token(Token = "0x60053D0")]
	[Address(RVA = "0x9AA790", Offset = "0x9A9990", VA = "0x1809AA790")]
	public SheetContentInputCardContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053D1")]
	[Address(RVA = "0x9AA460", Offset = "0x9A9660", VA = "0x1809AA460")]
	public SheetContentInputCardContext Copy()
	{
		return null;
	}

	[Token(Token = "0x60053D2")]
	[Address(RVA = "0x9AA550", Offset = "0x9A9750", VA = "0x1809AA550", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053D3")]
	[Address(RVA = "0x9AA670", Offset = "0x9A9870", VA = "0x1809AA670", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
