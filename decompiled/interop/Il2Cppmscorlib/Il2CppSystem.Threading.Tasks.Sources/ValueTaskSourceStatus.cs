using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks.Sources;

[OriginalName("mscorlib.dll", "System.Threading.Tasks.Sources", "ValueTaskSourceStatus")]
public enum ValueTaskSourceStatus
{
	Pending,
	Succeeded,
	Faulted,
	Canceled
}
