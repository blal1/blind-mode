using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class SubsystemDescriptorBindings : Il2CppSystem.Object
{
	private delegate System.IntPtr CreateDelegate(System.IntPtr descriptorPtr);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly CreateDelegate CreateDelegateField;

	static SubsystemDescriptorBindings()
	{
		Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemDescriptorBindings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr);
		NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_GetId_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr, 100663310);
		CreateDelegateField = IL2CPP.ResolveICall<CreateDelegate>("UnityEngine.SubsystemDescriptorBindings::Create");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1271723, RefRangeEnd = 1271724, XrefRangeStart = 1271718, XrefRangeEnd = 1271723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetId(System.IntPtr descriptorPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&descriptorPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271724, XrefRangeEnd = 1271726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetId_Injected(System.IntPtr descriptorPtr, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptorPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetId_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SubsystemDescriptorBindings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr Create(System.IntPtr descriptorPtr)
	{
		return CreateDelegateField(descriptorPtr);
	}
}
