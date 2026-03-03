using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading;

[OriginalName("mscorlib.dll", "System.Threading", "ThreadState")]
[System.Flags]
public enum ThreadState
{
	Running = 0,
	StopRequested = 1,
	SuspendRequested = 2,
	Background = 4,
	Unstarted = 8,
	Stopped = 0x10,
	WaitSleepJoin = 0x20,
	Suspended = 0x40,
	AbortRequested = 0x80,
	Aborted = 0x100
}
