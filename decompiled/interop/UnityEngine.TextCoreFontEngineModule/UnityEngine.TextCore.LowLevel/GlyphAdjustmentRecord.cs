using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GlyphAdjustmentRecord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphValueRecord;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0;

	[FieldOffset(0)]
	public uint m_GlyphIndex;

	[FieldOffset(4)]
	public GlyphValueRecord m_GlyphValueRecord;

	public unsafe uint glyphIndex
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_GlyphIndex = value;
		}
	}

	public unsafe GlyphValueRecord glyphValueRecord
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1240129, RefRangeEnd = 1240145, XrefRangeStart = 1240129, XrefRangeEnd = 1240145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphValueRecord*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_GlyphValueRecord = value;
		}
	}

	static GlyphAdjustmentRecord()
	{
		Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphIndex");
		NativeFieldInfoPtr_m_GlyphValueRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, "m_GlyphValueRecord");
		NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_get_glyphValueRecord_Public_get_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, 100663447);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1120061, RefRangeEnd = 1120073, XrefRangeStart = 1120061, XrefRangeEnd = 1120073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&glyphIndex);
		*(GlyphValueRecord**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &glyphValueRecord;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273673, XrefRangeEnd = 1273677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273677, XrefRangeEnd = 1273681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273681, XrefRangeEnd = 1273687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(GlyphAdjustmentRecord other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphAdjustmentRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs)
	{
		return lhs.m_GlyphIndex == rhs.m_GlyphIndex && lhs.m_GlyphValueRecord == rhs.m_GlyphValueRecord;
	}

	public static bool operator !=(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs)
	{
		return !(lhs == rhs);
	}
}
