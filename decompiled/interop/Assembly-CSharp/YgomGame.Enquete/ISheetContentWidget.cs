using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Enquete;

[Token(Token = "0x2000E20")]
public interface ISheetContentWidget
{
	[Token(Token = "0x17000CC4")]
	string label
	{
		[Token(Token = "0x6005596")]
		get;
	}

	[Token(Token = "0x6005597")]
	void ImportInputValues(Dictionary<string, object> importValues);

	[Token(Token = "0x6005598")]
	void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap);

	[Token(Token = "0x6005599")]
	void CollectInputValues(Dictionary<string, object> resultValues);
}
