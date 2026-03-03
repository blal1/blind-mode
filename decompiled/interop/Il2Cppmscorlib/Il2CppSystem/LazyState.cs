using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem;

[OriginalName("mscorlib.dll", "System", "LazyState")]
public enum LazyState
{
	NoneViaConstructor,
	NoneViaFactory,
	NoneException,
	PublicationOnlyViaConstructor,
	PublicationOnlyViaFactory,
	PublicationOnlyWait,
	PublicationOnlyException,
	ExecutionAndPublicationViaConstructor,
	ExecutionAndPublicationViaFactory,
	ExecutionAndPublicationException
}
