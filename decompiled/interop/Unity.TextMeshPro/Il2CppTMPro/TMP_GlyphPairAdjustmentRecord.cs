using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro;

[System.Serializable]
public class TMP_GlyphPairAdjustmentRecord : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0;

	public unsafe TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstAdjustmentRecord);
			return *(TMP_GlyphAdjustmentRecord*)num;
		}
		set
		{
			*(TMP_GlyphAdjustmentRecord*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstAdjustmentRecord)) = value;
		}
	}

	public unsafe TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondAdjustmentRecord);
			return *(TMP_GlyphAdjustmentRecord*)num;
		}
		set
		{
			*(TMP_GlyphAdjustmentRecord*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondAdjustmentRecord)) = value;
		}
	}

	public unsafe FontFeatureLookupFlags m_FeatureLookupFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeatureLookupFlags);
			return *(FontFeatureLookupFlags*)num;
		}
		set
		{
			*(FontFeatureLookupFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeatureLookupFlags)) = value;
		}
	}

	public unsafe TMP_GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TMP_GlyphAdjustmentRecord*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TMP_GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TMP_GlyphAdjustmentRecord*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe FontFeatureLookupFlags featureLookupFlags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FontFeatureLookupFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202040, RefRangeEnd = 202045, XrefRangeStart = 202040, XrefRangeEnd = 202045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static TMP_GlyphPairAdjustmentRecord()
	{
		Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphPairAdjustmentRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
		NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
		NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
		NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100664037);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124528, XrefRangeEnd = 1124529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&firstAdjustmentRecord);
		*(TMP_GlyphAdjustmentRecord**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondAdjustmentRecord;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124529, XrefRangeEnd = 1124544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphPairAdjustmentRecord);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_GlyphPairAdjustmentRecord(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
