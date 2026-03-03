using Il2CppDummyDll;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FDF")]
public interface IContentPostAllInsertedHandler
{
	[Token(Token = "0x17000F22")]
	bool rebuildLayoutOnPostAllInserted
	{
		[Token(Token = "0x6006022")]
		get;
	}

	[Token(Token = "0x6006023")]
	void OnPostAllInserted();
}
