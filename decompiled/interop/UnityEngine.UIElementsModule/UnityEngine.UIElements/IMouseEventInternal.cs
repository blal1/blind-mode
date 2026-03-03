using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001F3")]
internal interface IMouseEventInternal
{
	[Token(Token = "0x17000282")]
	bool triggeredByOS
	{
		[Token(Token = "0x6000E09")]
		get;
		[Token(Token = "0x6000E0A")]
		set;
	}

	[Token(Token = "0x17000283")]
	IPointerEvent sourcePointerEvent
	{
		[Token(Token = "0x6000E0B")]
		get;
		[Token(Token = "0x6000E0C")]
		set;
	}
}
