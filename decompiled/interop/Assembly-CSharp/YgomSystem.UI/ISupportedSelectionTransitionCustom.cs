using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200049C")]
public interface ISupportedSelectionTransitionCustom
{
	[Token(Token = "0x6001E31")]
	bool TrySelectionTransitionCustom(PadInputDirection direction, SelectionItem target, bool initializeSelection = false);
}
