using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000225")]
internal interface IPointerOrMouseEvent
{
	[Token(Token = "0x170002BC")]
	int pointerId
	{
		[Token(Token = "0x6000F0F")]
		get;
	}

	[Token(Token = "0x170002BD")]
	Vector3 position
	{
		[Token(Token = "0x6000F10")]
		get;
	}
}
