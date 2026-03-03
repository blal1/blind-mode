using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class ScalableBufferManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0;

	public unsafe static float widthScaleFactor
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1173281, RefRangeEnd = 1173289, XrefRangeStart = 1173279, XrefRangeEnd = 1173281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float heightScaleFactor
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1173291, RefRangeEnd = 1173299, XrefRangeStart = 1173289, XrefRangeEnd = 1173291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ScalableBufferManager()
	{
		Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScalableBufferManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr);
		NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664427);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173301, RefRangeEnd = 1173302, XrefRangeStart = 1173299, XrefRangeEnd = 1173301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResizeBuffers(float widthScale, float heightScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&widthScale);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightScale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScalableBufferManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
