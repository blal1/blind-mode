using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F5")]
public interface IVisualElementScheduler
{
	[Token(Token = "0x60023BA")]
	IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent);

	[Token(Token = "0x60023BB")]
	IVisualElementScheduledItem Execute(Action updateEvent);
}
