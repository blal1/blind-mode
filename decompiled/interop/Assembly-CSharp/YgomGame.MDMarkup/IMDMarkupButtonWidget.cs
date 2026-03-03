using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D11")]
public interface IMDMarkupButtonWidget : IMDMarkupButtonContainWidget
{
	[Token(Token = "0x17000B40")]
	SelectionButton button
	{
		[Token(Token = "0x6004EFB")]
		get;
	}

	[Token(Token = "0x6004EFC")]
	void SetOnClick(UnityAction callback);
}
