using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F4")]
public interface IVisualElementScheduledItem
{
	[Token(Token = "0x1700095F")]
	bool isActive
	{
		[Token(Token = "0x60023B3")]
		get;
	}

	[Token(Token = "0x60023B4")]
	void Resume();

	[Token(Token = "0x60023B5")]
	void Pause();

	[Token(Token = "0x60023B6")]
	void ExecuteLater(long delayMs);

	[Token(Token = "0x60023B7")]
	IVisualElementScheduledItem StartingIn(long delayMs);

	[Token(Token = "0x60023B8")]
	IVisualElementScheduledItem Every(long intervalMs);

	[Token(Token = "0x60023B9")]
	IVisualElementScheduledItem Until(Func<bool> stopCondition);
}
