using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000465")]
public interface ITextSelection
{
	[Token(Token = "0x170008F4")]
	bool isSelectable
	{
		[Token(Token = "0x6002148")]
		get;
		[Token(Token = "0x6002149")]
		set;
	}

	[Token(Token = "0x170008F5")]
	int cursorIndex
	{
		[Token(Token = "0x600214A")]
		get;
		[Token(Token = "0x600214B")]
		set;
	}

	[Token(Token = "0x170008F6")]
	bool doubleClickSelectsWord
	{
		[Token(Token = "0x600214C")]
		get;
		[Token(Token = "0x600214D")]
		set;
	}

	[Token(Token = "0x170008F7")]
	int selectIndex
	{
		[Token(Token = "0x600214E")]
		get;
		[Token(Token = "0x600214F")]
		set;
	}

	[Token(Token = "0x170008F8")]
	bool tripleClickSelectsLine
	{
		[Token(Token = "0x6002150")]
		get;
		[Token(Token = "0x6002151")]
		set;
	}

	[Token(Token = "0x170008F9")]
	bool selectAllOnFocus
	{
		[Token(Token = "0x6002155")]
		get;
		[Token(Token = "0x6002156")]
		set;
	}

	[Token(Token = "0x170008FA")]
	bool selectAllOnMouseUp
	{
		[Token(Token = "0x6002157")]
		get;
		[Token(Token = "0x6002158")]
		set;
	}

	[Token(Token = "0x170008FB")]
	Vector2 cursorPosition
	{
		[Token(Token = "0x6002159")]
		get;
	}

	[Token(Token = "0x170008FC")]
	internal float lineHeightAtCursorPosition
	{
		[Token(Token = "0x600215A")]
		get;
	}

	[Token(Token = "0x170008FD")]
	internal float cursorWidth
	{
		[Token(Token = "0x600215B")]
		get;
	}

	[Token(Token = "0x6002152")]
	bool HasSelection();

	[Token(Token = "0x6002153")]
	void SelectAll();

	[Token(Token = "0x6002154")]
	void SelectNone();
}
