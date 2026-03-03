using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FBF")]
public class EntryScrollTextData : EntryDataBase
{
	[Token(Token = "0x400AA94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x400AA95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxHeight;

	[Token(Token = "0x400AA96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x17000F08")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F78")]
	[Address(RVA = "0xA6B5A0", Offset = "0xA6A7A0", VA = "0x180A6B5A0")]
	public EntryScrollTextData([Optional] string text, int maxHeight = 32, TextAlignmentOptions alignment = TextAlignmentOptions.Midline)
	{
	}
}
