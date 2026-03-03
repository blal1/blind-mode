using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class UISystemProfilerApi : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.UIModule.dll", "", "SampleType")]
	public enum SampleType
	{
		Layout,
		Render
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMarker_Injected_Private_Static_Void_byref_ManagedSpanWrapper_IntPtr_0;

	static UISystemProfilerApi()
	{
		Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "UISystemProfilerApi");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr);
		NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_AddMarker_Injected_Private_Static_Void_byref_ManagedSpanWrapper_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663465);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1407545, RefRangeEnd = 1407547, XrefRangeStart = 1407543, XrefRangeEnd = 1407545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginSample(SampleType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1407549, RefRangeEnd = 1407551, XrefRangeStart = 1407547, XrefRangeEnd = 1407549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndSample(SampleType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1407568, RefRangeEnd = 1407582, XrefRangeStart = 1407551, XrefRangeEnd = 1407568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddMarker(string name, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407582, XrefRangeEnd = 1407584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddMarker_Injected(ref ManagedSpanWrapper name, System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMarker_Injected_Private_Static_Void_byref_ManagedSpanWrapper_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UISystemProfilerApi(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
