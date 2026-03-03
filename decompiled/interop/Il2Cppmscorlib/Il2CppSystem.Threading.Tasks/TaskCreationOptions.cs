using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks;

[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskCreationOptions")]
[System.Flags]
public enum TaskCreationOptions
{
	None = 0,
	PreferFairness = 1,
	LongRunning = 2,
	AttachedToParent = 4,
	DenyChildAttach = 8,
	HideScheduler = 0x10,
	RunContinuationsAsynchronously = 0x40
}
