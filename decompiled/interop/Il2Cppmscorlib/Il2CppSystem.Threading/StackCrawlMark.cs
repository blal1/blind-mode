using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Threading", "StackCrawlMark")]
public enum StackCrawlMark
{
	LookForMe,
	LookForMyCaller,
	LookForMyCallersCaller,
	LookForThread
}
