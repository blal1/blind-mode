using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MarkToMarkAdjustmentRecord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaseMarkGlyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaseMarkGlyphAnchorPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CombiningMarkGlyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CombiningMarkPositionAdjustment;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_baseMarkGlyphID_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_baseMarkGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_combiningMarkGlyphID_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_combiningMarkPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0;

	[FieldOffset(0)]
	public uint m_BaseMarkGlyphID;

	[FieldOffset(4)]
	public GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

	[FieldOffset(12)]
	public uint m_CombiningMarkGlyphID;

	[FieldOffset(16)]
	public MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

	public unsafe uint baseMarkGlyphID
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_baseMarkGlyphID_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphAnchorPoint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1113952, RefRangeEnd = 1113956, XrefRangeStart = 1113952, XrefRangeEnd = 1113956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_baseMarkGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint combiningMarkGlyphID
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376363, XrefRangeStart = 376360, XrefRangeEnd = 376363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_combiningMarkGlyphID_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MarkPositionAdjustment combiningMarkPositionAdjustment
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MarkPositionAdjustment*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327424, RefRangeEnd = 327426, XrefRangeStart = 327424, XrefRangeEnd = 327426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_combiningMarkPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static MarkToMarkAdjustmentRecord()
	{
		Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MarkToMarkAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_BaseMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphID");
		NativeFieldInfoPtr_m_BaseMarkGlyphAnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphAnchorPoint");
		NativeFieldInfoPtr_m_CombiningMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkGlyphID");
		NativeFieldInfoPtr_m_CombiningMarkPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkPositionAdjustment");
		NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_set_baseMarkGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_set_baseMarkGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_set_combiningMarkGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_set_combiningMarkPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663339);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
