using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct InclusiveRange
{
	private static readonly System.IntPtr NativeFieldInfoPtr_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_end;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public short start;

	[FieldOffset(2)]
	public short end;

	public unsafe bool isEmpty
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static InclusiveRange empty
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InclusiveRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InclusiveRange()
	{
		Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "InclusiveRange");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr);
		NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, "start");
		NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, "end");
		NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665605);
		NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665606);
		NativeMethodInfoPtr_Expand_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665607);
		NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665608);
		NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665609);
		NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665610);
		NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665611);
		NativeMethodInfoPtr_get_empty_Public_Static_get_InclusiveRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665612);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, 100665613);
	}

	[CallerCount(0)]
	public unsafe InclusiveRange(short startEnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startEnd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 817658, RefRangeEnd = 817659, XrefRangeStart = 817658, XrefRangeEnd = 817659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InclusiveRange(short start, short end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1100584, RefRangeEnd = 1100600, XrefRangeStart = 1100579, XrefRangeEnd = 1100584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Expand(short index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Expand_Public_Void_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1100605, RefRangeEnd = 1100610, XrefRangeStart = 1100600, XrefRangeEnd = 1100605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clamp(short min, short max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clamp_Public_Void_Int16_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool Contains(short index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1100615, RefRangeEnd = 1100623, XrefRangeStart = 1100610, XrefRangeEnd = 1100615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InclusiveRange Merge(InclusiveRange a, InclusiveRange b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(InclusiveRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge_Public_Static_InclusiveRange_InclusiveRange_InclusiveRange_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InclusiveRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100623, XrefRangeEnd = 1100630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InclusiveRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
