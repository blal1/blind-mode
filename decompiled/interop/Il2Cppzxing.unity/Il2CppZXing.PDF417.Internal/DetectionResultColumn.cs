using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal;

public class DetectionResultColumn : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Box_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Codewords_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Box_Private_set_Void_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Codewords_Public_get_Il2CppReferenceArray_1_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Codewords_Public_set_Void_Il2CppReferenceArray_1_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexForRow_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodeword_Public_Codeword_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodewordNearby_Public_Codeword_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_imageRowToCodewordIndex_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCodeword_Public_Void_Int32_Codeword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe BoundingBox _Box_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Box_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Box_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Codeword> _Codewords_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Codewords_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Codeword>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Codewords_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BoundingBox Box
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBox>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Box_Private_set_Void_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<Codeword> Codewords
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Codewords_Public_get_Il2CppReferenceArray_1_Codeword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Codeword>>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Codewords_Public_set_Void_Il2CppReferenceArray_1_Codeword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DetectionResultColumn()
	{
		Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "DetectionResultColumn");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr);
		NativeFieldInfoPtr__Box_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, "<Box>k__BackingField");
		NativeFieldInfoPtr__Codewords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, "<Codewords>k__BackingField");
		NativeMethodInfoPtr_get_Box_Public_get_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_set_Box_Private_set_Void_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_get_Codewords_Public_get_Il2CppReferenceArray_1_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_set_Codewords_Public_set_Void_Il2CppReferenceArray_1_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_IndexForRow_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_getCodeword_Public_Codeword_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_getCodewordNearby_Public_Codeword_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_imageRowToCodewordIndex_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_setCodeword_Public_Void_Int32_Codeword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr, 100663902);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1418660, RefRangeEnd = 1418666, XrefRangeStart = 1418644, XrefRangeEnd = 1418660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DetectionResultColumn(BoundingBox box)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetectionResultColumn>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)box);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BoundingBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int IndexForRow(int imageRow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&imageRow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexForRow_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Codeword getCodeword(int imageRow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&imageRow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodeword_Public_Codeword_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Codeword>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe Codeword getCodewordNearby(int imageRow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&imageRow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodewordNearby_Public_Codeword_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Codeword>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe int imageRowToCodewordIndex(int imageRow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&imageRow);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_imageRowToCodewordIndex_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1418669, RefRangeEnd = 1418673, XrefRangeStart = 1418666, XrefRangeEnd = 1418669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCodeword(int imageRow, Codeword codeword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&imageRow);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codeword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCodeword_Public_Void_Int32_Codeword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418724, RefRangeEnd = 1418725, XrefRangeStart = 1418673, XrefRangeEnd = 1418724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public DetectionResultColumn(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
