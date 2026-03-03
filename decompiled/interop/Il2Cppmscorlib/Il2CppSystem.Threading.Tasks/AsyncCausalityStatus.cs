using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks;

[OriginalName("mscorlib.dll", "System.Threading.Tasks", "AsyncCausalityStatus")]
public enum AsyncCausalityStatus
{
	Started,
	Completed,
	Canceled,
	Error
}
