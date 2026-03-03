using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FBE")]
public class EntryMaintenanceImageData : EntryDataBase
{
	[Token(Token = "0x400AA90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string textTitle;

	[Token(Token = "0x400AA91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string textDate;

	[Token(Token = "0x400AA92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string imagePath;

	[Token(Token = "0x400AA93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x17000F07")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x578DC0", Offset = "0x577FC0", VA = "0x180578DC0", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F76")]
	[Address(RVA = "0xA6B520", Offset = "0xA6A720", VA = "0x180A6B520")]
	public EntryMaintenanceImageData([Optional] string textTitle, [Optional] string textDate, [Optional] string imagePath, TextAlignmentOptions alignment = TextAlignmentOptions.Midline)
	{
	}
}
