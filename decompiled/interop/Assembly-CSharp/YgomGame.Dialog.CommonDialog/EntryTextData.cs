using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC0")]
public class EntryTextData : EntryDataBase
{
	[Token(Token = "0x400AA97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x400AA98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x400AA99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool baseVisible;

	[Token(Token = "0x17000F09")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F7A")]
	[Address(RVA = "0xA6B600", Offset = "0xA6A800", VA = "0x180A6B600")]
	public EntryTextData([Optional] string text, TextAlignmentOptions alignment = TextAlignmentOptions.Midline, bool baseVisible = true)
	{
	}
}
