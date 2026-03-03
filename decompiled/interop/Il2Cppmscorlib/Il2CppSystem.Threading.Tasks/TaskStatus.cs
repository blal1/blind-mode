using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks;

[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskStatus")]
public enum TaskStatus
{
	Created,
	WaitingForActivation,
	WaitingToRun,
	Running,
	WaitingForChildrenToComplete,
	RanToCompletion,
	Canceled,
	Faulted
}
