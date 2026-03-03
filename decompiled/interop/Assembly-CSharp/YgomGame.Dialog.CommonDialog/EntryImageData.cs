using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FB9")]
public class EntryImageData : EntryDataBase
{
	[Token(Token = "0x400AA7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x17000F02")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F60")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public EntryImageData([Optional] string path)
	{
	}
}
