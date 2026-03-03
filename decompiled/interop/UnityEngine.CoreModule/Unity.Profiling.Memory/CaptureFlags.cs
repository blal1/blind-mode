namespace Unity.Profiling.Memory;

public enum CaptureFlags : uint
{
	ManagedObjects = 1u,
	NativeObjects = 2u,
	NativeAllocations = 4u,
	NativeAllocationSites = 8u,
	NativeStackTraces = 0x10u
}
