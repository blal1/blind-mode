using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public static class SpeedTreeWindManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Public_Static_Void_ReadOnlySpan_1_Int32_SpeedTreeWindParamsBufferIterator_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_SpeedTreeWindParamsBufferIterator_Boolean_0;

	static SpeedTreeWindManager()
	{
		Il2CppClassPointerStore<SpeedTreeWindManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.Rendering", "SpeedTreeWindManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedTreeWindManager>.NativeClassPtr);
		NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Public_Static_Void_ReadOnlySpan_1_Int32_SpeedTreeWindParamsBufferIterator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTreeWindManager>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_SpeedTreeWindParamsBufferIterator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTreeWindManager>.NativeClassPtr, 100663347);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1272610, RefRangeEnd = 1272611, XrefRangeStart = 1272603, XrefRangeEnd = 1272610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWindAndWriteBufferWindParams(Il2CppSystem.ReadOnlySpan<int> renderersID, SpeedTreeWindParamsBufferIterator windParams, bool history)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersID));
		*(SpeedTreeWindParamsBufferIterator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &windParams;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &history;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Public_Static_Void_ReadOnlySpan_1_Int32_SpeedTreeWindParamsBufferIterator_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272611, XrefRangeEnd = 1272613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateWindAndWriteBufferWindParams_Injected(ref ManagedSpanWrapper renderersID, [In] ref SpeedTreeWindParamsBufferIterator windParams, bool history)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref renderersID);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref windParams);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &history;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWindAndWriteBufferWindParams_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_SpeedTreeWindParamsBufferIterator_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpeedTreeWindManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
