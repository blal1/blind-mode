using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

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
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1252492, RefRangeEnd = 1252523, XrefRangeStart = 1252492, XrefRangeEnd = 1252523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(115)]
		[CachedScanResults(RefRangeStart = 1165832, RefRangeEnd = 1165947, XrefRangeStart = 1165832, XrefRangeEnd = 1165947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1258926, RefRangeEnd = 1258945, XrefRangeStart = 1258926, XrefRangeEnd = 1258945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MarkToMarkAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_BaseMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphID");
		NativeFieldInfoPtr_m_BaseMarkGlyphAnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_BaseMarkGlyphAnchorPoint");
		NativeFieldInfoPtr_m_CombiningMarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkGlyphID");
		NativeFieldInfoPtr_m_CombiningMarkPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, "m_CombiningMarkPositionAdjustment");
		NativeMethodInfoPtr_get_baseMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_set_baseMarkGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_get_baseMarkGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_set_baseMarkGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_get_combiningMarkGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_set_combiningMarkGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_get_combiningMarkPositionAdjustment_Public_get_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_set_combiningMarkPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, 100663479);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkToMarkAdjustmentRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
