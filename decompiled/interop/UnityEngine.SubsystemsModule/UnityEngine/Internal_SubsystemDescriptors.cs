using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public static class Internal_SubsystemDescriptors : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0;

	static Internal_SubsystemDescriptors()
	{
		Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "Internal_SubsystemDescriptors");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr);
		NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Internal_SubsystemDescriptors>.NativeClassPtr, 100663315);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271726, XrefRangeEnd = 1271736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_AddDescriptor(SubsystemDescriptor descriptor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_AddDescriptor_Internal_Static_Void_SubsystemDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Internal_SubsystemDescriptors(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
