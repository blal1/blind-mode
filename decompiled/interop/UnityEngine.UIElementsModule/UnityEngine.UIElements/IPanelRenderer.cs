using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B3")]
internal interface IPanelRenderer
{
	[Token(Token = "0x17000391")]
	bool forceGammaRendering
	{
		[Token(Token = "0x60012C2")]
		get;
		[Token(Token = "0x60012C3")]
		set;
	}

	[Token(Token = "0x17000392")]
	uint vertexBudget
	{
		[Token(Token = "0x60012C4")]
		get;
		[Token(Token = "0x60012C5")]
		set;
	}

	[Token(Token = "0x60012C6")]
	void Reset();

	[Token(Token = "0x60012C7")]
	void Render();
}
