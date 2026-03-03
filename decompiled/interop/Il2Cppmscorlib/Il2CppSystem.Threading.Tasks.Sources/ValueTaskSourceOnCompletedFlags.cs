using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks.Sources;

[OriginalName("mscorlib.dll", "System.Threading.Tasks.Sources", "ValueTaskSourceOnCompletedFlags")]
[System.Flags]
public enum ValueTaskSourceOnCompletedFlags
{
	None = 0,
	UseSchedulingContext = 1,
	FlowExecutionContext = 2
}
