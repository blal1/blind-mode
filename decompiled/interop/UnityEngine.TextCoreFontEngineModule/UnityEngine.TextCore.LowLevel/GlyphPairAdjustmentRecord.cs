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
public struct GlyphPairAdjustmentRecord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GlyphAdjustmentRecord_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0;

	[FieldOffset(0)]
	public GlyphAdjustmentRecord m_FirstAdjustmentRecord;

	[FieldOffset(20)]
	public GlyphAdjustmentRecord m_SecondAdjustmentRecord;

	[FieldOffset(40)]
	public FontFeatureLookupFlags m_FeatureLookupFlags;

	public unsafe GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1273687, RefRangeEnd = 1273701, XrefRangeStart = 1273687, XrefRangeEnd = 1273687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphAdjustmentRecord*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1000426, RefRangeEnd = 1000428, XrefRangeStart = 1000426, XrefRangeEnd = 1000428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_GlyphAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1272656, RefRangeEnd = 1272698, XrefRangeStart = 1272656, XrefRangeEnd = 1272698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphAdjustmentRecord*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SecondAdjustmentRecord = value;
		}
	}

	public unsafe FontFeatureLookupFlags featureLookupFlags
	{
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1222676, RefRangeEnd = 1222709, XrefRangeStart = 1222676, XrefRangeEnd = 1222709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FontFeatureLookupFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_FeatureLookupFlags = value;
		}
	}

	static GlyphPairAdjustmentRecord()
	{
		Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphPairAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
		NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
		NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
		NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr__ctor_Public_Void_GlyphAdjustmentRecord_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, 100663455);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273701, RefRangeEnd = 1273702, XrefRangeStart = 1273701, XrefRangeEnd = 1273701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&firstAdjustmentRecord);
		*(GlyphAdjustmentRecord**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondAdjustmentRecord;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GlyphAdjustmentRecord_GlyphAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273702, XrefRangeEnd = 1273706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273706, XrefRangeEnd = 1273710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273710, XrefRangeEnd = 1273716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(GlyphPairAdjustmentRecord other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphPairAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairAdjustmentRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs)
	{
		return lhs.m_FirstAdjustmentRecord == rhs.m_FirstAdjustmentRecord && lhs.m_SecondAdjustmentRecord == rhs.m_SecondAdjustmentRecord;
	}

	public static bool operator !=(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs)
	{
		return !(lhs == rhs);
	}
}
