using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MarkToBaseAdjustmentRecord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaseGlyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BaseGlyphAnchorPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkGlyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkPositionAdjustment;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_baseGlyphID_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_baseGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_markGlyphID_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_markPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0;

	[FieldOffset(0)]
	public uint m_BaseGlyphID;

	[FieldOffset(4)]
	public GlyphAnchorPoint m_BaseGlyphAnchorPoint;

	[FieldOffset(12)]
	public uint m_MarkGlyphID;

	[FieldOffset(16)]
	public MarkPositionAdjustment m_MarkPositionAdjustment;

	public unsafe uint baseGlyphID
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_baseGlyphID_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphAnchorPoint baseGlyphAnchorPoint
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphAnchorPoint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1113952, RefRangeEnd = 1113956, XrefRangeStart = 1113952, XrefRangeEnd = 1113952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_baseGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint markGlyphID
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_markGlyphID_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MarkPositionAdjustment markPositionAdjustment
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_markPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static MarkToBaseAdjustmentRecord()
	{
		Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MarkToBaseAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_BaseGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_BaseGlyphID");
		NativeFieldInfoPtr_m_BaseGlyphAnchorPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_BaseGlyphAnchorPoint");
		NativeFieldInfoPtr_m_MarkGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_MarkGlyphID");
		NativeFieldInfoPtr_m_MarkPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, "m_MarkPositionAdjustment");
		NativeMethodInfoPtr_get_baseGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_set_baseGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_get_baseGlyphAnchorPoint_Public_get_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_set_baseGlyphAnchorPoint_Public_set_Void_GlyphAnchorPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_get_markGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_set_markGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_get_markPositionAdjustment_Public_get_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_set_markPositionAdjustment_Public_set_Void_MarkPositionAdjustment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, 100663331);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkToBaseAdjustmentRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
