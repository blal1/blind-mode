using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Enquete;

[Token(Token = "0x2000DE7")]
public class SheetContentInputAmountContext : SheetContentContextBase
{
	[Token(Token = "0x400A11B")]
	[FieldOffset(Offset = "0x28")]
	public readonly GlobalTextData minText;

	[Token(Token = "0x400A11C")]
	[FieldOffset(Offset = "0x30")]
	public readonly GlobalTextData maxText;

	[Token(Token = "0x400A11D")]
	[FieldOffset(Offset = "0x38")]
	public int amountLength;

	[Token(Token = "0x17000C51")]
	public override SheetContentType sheetContentType
	{
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x4446D0", Offset = "0x4438D0", VA = "0x1804446D0", Slot = "15")]
		get
		{
			return default(SheetContentType);
		}
	}

	[Token(Token = "0x17000C52")]
	public override bool isInput
	{
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60053CA")]
	[Address(RVA = "0x9AA380", Offset = "0x9A9580", VA = "0x1809AA380")]
	public SheetContentInputAmountContext(object jsonData, RootContext rootContext)
	{
	}

	[Token(Token = "0x60053CB")]
	[Address(RVA = "0x9AA1C0", Offset = "0x9A93C0", VA = "0x1809AA1C0", Slot = "7")]
	public override void Import(object jsonData)
	{
	}

	[Token(Token = "0x60053CC")]
	[Address(RVA = "0x9AA2C0", Offset = "0x9A94C0", VA = "0x1809AA2C0", Slot = "9")]
	public override void SearchDependencieTextGroups(List<string> resultList)
	{
	}
}
