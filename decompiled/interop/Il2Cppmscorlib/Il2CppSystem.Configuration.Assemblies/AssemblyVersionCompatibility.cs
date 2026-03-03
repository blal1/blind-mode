using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Configuration.Assemblies;

[OriginalName("mscorlib.dll", "System.Configuration.Assemblies", "AssemblyVersionCompatibility")]
public enum AssemblyVersionCompatibility
{
	SameMachine = 1,
	SameProcess,
	SameDomain
}
