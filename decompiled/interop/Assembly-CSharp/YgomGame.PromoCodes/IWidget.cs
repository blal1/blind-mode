using System.Collections;
using Il2CppDummyDll;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B89")]
public interface IWidget
{
	[Token(Token = "0x17000979")]
	bool IsReady
	{
		[Token(Token = "0x600466F")]
		get;
	}

	[Token(Token = "0x600466C")]
	void BeginInitialize(PromoCodesViewController.SourceContainer sourceContainer);

	[Token(Token = "0x600466D")]
	void SubmitSource(IWidgetSource widgetSource);

	[Token(Token = "0x600466E")]
	IEnumerator ProgressInitialize();
}
