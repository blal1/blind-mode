using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks;

[OriginalName("mscorlib.dll", "System.Threading.Tasks", "CausalityRelation")]
public enum CausalityRelation
{
	AssignDelegate,
	Join,
	Choice,
	Cancel,
	Error
}
