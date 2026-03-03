using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.LowLevelPhysics;

public static class ImmediatePhysics
{
	private delegate int GenerateContacts_NativeDelegate(IntPtr geom1, IntPtr geom2, IntPtr xform1, IntPtr xform2, int numPairs, IntPtr contacts, int contactArrayLength, IntPtr sizes, int sizesArrayLength, float contactDistance);

	private static readonly GenerateContacts_NativeDelegate GenerateContacts_NativeDelegateField = IL2CPP.ResolveICall<GenerateContacts_NativeDelegate>("UnityEngine.LowLevelPhysics.ImmediatePhysics::GenerateContacts_Native");

	public unsafe static int GenerateContacts_Native(void* geom1, void* geom2, void* xform1, void* xform2, int numPairs, void* contacts, int contactArrayLength, void* sizes, int sizesArrayLength, float contactDistance)
	{
		return GenerateContacts_NativeDelegateField((nint)geom1, (nint)geom2, (nint)xform1, (nint)xform2, numPairs, (nint)contacts, contactArrayLength, (nint)sizes, sizesArrayLength, contactDistance);
	}
}
