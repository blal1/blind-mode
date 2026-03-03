using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC2")]
public class EntryTitleData : EntryDataBase
{
	[Token(Token = "0x400AA9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x400AAA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CommonDialogTitleWidget.IconType iconType;

	[Token(Token = "0x17000F0B")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F7E")]
	[Address(RVA = "0xA6B6F0", Offset = "0xA6A8F0", VA = "0x180A6B6F0")]
	public EntryTitleData([Optional] string text, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None)
	{
	}
}
