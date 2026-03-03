using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000C95")]
public interface IMDMarkupTableContent : IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId
{
	[Token(Token = "0x6004C46")]
	object ExportJsonObj();

	[Token(Token = "0x6004C47")]
	void ImportJsonObj(object jsonObj);
}
