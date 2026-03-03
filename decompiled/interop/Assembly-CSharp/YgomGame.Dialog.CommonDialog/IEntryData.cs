using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC3")]
public interface IEntryData
{
	[Token(Token = "0x17000F0C")]
	CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F7F")]
		get;
	}

	[Token(Token = "0x17000F0D")]
	string entryLabel
	{
		[Token(Token = "0x6005F80")]
		get;
		[Token(Token = "0x6005F81")]
		set;
	}
}
