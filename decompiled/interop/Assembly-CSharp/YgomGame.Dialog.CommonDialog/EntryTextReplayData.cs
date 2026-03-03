using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC1")]
public class EntryTextReplayData : EntryDataBase
{
	[Token(Token = "0x400AA9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x400AA9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string textNum;

	[Token(Token = "0x400AA9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string textUnit;

	[Token(Token = "0x400AA9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x400AA9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool baseVisible;

	[Token(Token = "0x17000F0A")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F7C")]
	[Address(RVA = "0xA6B660", Offset = "0xA6A860", VA = "0x180A6B660")]
	public EntryTextReplayData([Optional] string text, [Optional] string textNum, [Optional] string textUnit, TextAlignmentOptions alignment = TextAlignmentOptions.Midline, bool baseVisible = true)
	{
	}
}
