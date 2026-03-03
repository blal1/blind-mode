using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection;

[OriginalName("mscorlib.dll", "System.Reflection", "ExceptionHandlingClauseOptions")]
[System.Flags]
public enum ExceptionHandlingClauseOptions
{
	Clause = 0,
	Filter = 1,
	Finally = 2,
	Fault = 4
}
