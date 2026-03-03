using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001F2")]
public interface IMouseEvent
{
	[Token(Token = "0x1700027B")]
	EventModifiers modifiers
	{
		[Token(Token = "0x6000E02")]
		get;
	}

	[Token(Token = "0x1700027C")]
	Vector2 mousePosition
	{
		[Token(Token = "0x6000E03")]
		get;
	}

	[Token(Token = "0x1700027D")]
	Vector2 localMousePosition
	{
		[Token(Token = "0x6000E04")]
		get;
	}

	[Token(Token = "0x1700027E")]
	Vector2 mouseDelta
	{
		[Token(Token = "0x6000E05")]
		get;
	}

	[Token(Token = "0x1700027F")]
	int clickCount
	{
		[Token(Token = "0x6000E06")]
		get;
	}

	[Token(Token = "0x17000280")]
	int button
	{
		[Token(Token = "0x6000E07")]
		get;
	}

	[Token(Token = "0x17000281")]
	int pressedButtons
	{
		[Token(Token = "0x6000E08")]
		get;
	}
}
