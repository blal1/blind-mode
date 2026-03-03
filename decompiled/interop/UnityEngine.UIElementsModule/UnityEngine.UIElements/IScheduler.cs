using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002BB")]
internal interface IScheduler
{
	[Token(Token = "0x600130A")]
	void Unschedule(ScheduledItem item);

	[Token(Token = "0x600130B")]
	void Schedule(ScheduledItem item);

	[Token(Token = "0x600130C")]
	void UpdateScheduledEvents();
}
