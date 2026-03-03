using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000224")]
internal interface IPointerEventInternal
{
	[Token(Token = "0x170002B9")]
	bool triggeredByOS
	{
		[Token(Token = "0x6000F0A")]
		get;
		[Token(Token = "0x6000F0B")]
		set;
	}

	[Token(Token = "0x170002BA")]
	IMouseEvent compatibilityMouseEvent
	{
		[Token(Token = "0x6000F0C")]
		get;
		[Token(Token = "0x6000F0D")]
		set;
	}

	[Token(Token = "0x170002BB")]
	int displayIndex
	{
		[Token(Token = "0x6000F0E")]
		set;
	}
}
