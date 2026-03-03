using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FB8")]
public class EntryIconTextData : EntryDataBase
{
	[Token(Token = "0x400AA77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CommonDialogIconTextWidget.IconType iconType;

	[Token(Token = "0x400AA78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string text;

	[Token(Token = "0x400AA79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string iconPath;

	[Token(Token = "0x400AA7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string numText;

	[Token(Token = "0x400AA7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool itemIsPeriod;

	[Token(Token = "0x400AA7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int itemCategory;

	[Token(Token = "0x400AA7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int itemId;

	[Token(Token = "0x400AA7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool baseVisible;

	[Token(Token = "0x17000F01")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F5C")]
	[Address(RVA = "0xA6AD30", Offset = "0xA69F30", VA = "0x180A6AD30")]
	public EntryIconTextData(CommonDialogIconTextWidget.IconType iconType, string text, [Optional] string numText)
	{
	}

	[Token(Token = "0x6005F5D")]
	[Address(RVA = "0xA6ACB0", Offset = "0xA69EB0", VA = "0x180A6ACB0")]
	public EntryIconTextData(string iconPath, string text, [Optional] string numText)
	{
	}

	[Token(Token = "0x6005F5E")]
	[Address(RVA = "0xA6AD90", Offset = "0xA69F90", VA = "0x180A6AD90")]
	public EntryIconTextData(bool itemIsPeriod, int itemCategory, int itemId, string text, [Optional] string numText)
	{
	}
}
