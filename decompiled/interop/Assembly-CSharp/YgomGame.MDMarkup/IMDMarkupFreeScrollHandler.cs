using Il2CppDummyDll;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CEB")]
public interface IMDMarkupFreeScrollHandler
{
	[Token(Token = "0x6004E0C")]
	void AssignSelectionItem(SelectionItem selectionItem);

	[Token(Token = "0x6004E0D")]
	void ProgressSelectionPosY();

	[Token(Token = "0x6004E0E")]
	void SetFreeScrollView(FreeScrollView scroll);
}
