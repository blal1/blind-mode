using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FBA")]
public class EntryInsertWidgetData : EntryDataBase
{
	[Token(Token = "0x400AA80")]
	[FieldOffset(Offset = "0x18")]
	public IContentWidget insertWidget;

	[Token(Token = "0x17000F03")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F62")]
	[Address(RVA = "0x6A1440", Offset = "0x6A0640", VA = "0x1806A1440")]
	public EntryInsertWidgetData(IContentWidget insertWidget)
	{
	}
}
