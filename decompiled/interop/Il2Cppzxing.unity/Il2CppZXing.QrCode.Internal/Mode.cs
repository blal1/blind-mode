using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.QrCode.Internal;

public sealed class Mode : Il2CppSystem.Object
{
	[OriginalName("zxing.unity.dll", "", "Names")]
	public enum Names
	{
		TERMINATOR,
		NUMERIC,
		ALPHANUMERIC,
		STRUCTURED_APPEND,
		BYTE,
		ECI,
		KANJI,
		FNC1_FIRST_POSITION,
		FNC1_SECOND_POSITION,
		HANZI
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERMINATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_NUMERIC;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALPHANUMERIC;

	private static readonly System.IntPtr NativeFieldInfoPtr_STRUCTURED_APPEND;

	private static readonly System.IntPtr NativeFieldInfoPtr_BYTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ECI;

	private static readonly System.IntPtr NativeFieldInfoPtr_KANJI;

	private static readonly System.IntPtr NativeFieldInfoPtr_FNC1_FIRST_POSITION;

	private static readonly System.IntPtr NativeFieldInfoPtr_FNC1_SECOND_POSITION;

	private static readonly System.IntPtr NativeFieldInfoPtr_HANZI;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterCountBitsForVersions;

	private static readonly System.IntPtr NativeFieldInfoPtr__Bits_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_Names_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_Names_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int32_Int32_Names_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_forBits_Public_Static_Mode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCharacterCountBits_Public_Int32_Version_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Bits_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Bits_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe Names _Name_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField);
			return *(Names*)num;
		}
		set
		{
			*(Names*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField)) = value;
		}
	}

	public unsafe static Mode TERMINATOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERMINATOR, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERMINATOR, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode NUMERIC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NUMERIC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NUMERIC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode ALPHANUMERIC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALPHANUMERIC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALPHANUMERIC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode STRUCTURED_APPEND
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STRUCTURED_APPEND, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STRUCTURED_APPEND, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode BYTE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BYTE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BYTE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode ECI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ECI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ECI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode KANJI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KANJI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KANJI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode FNC1_FIRST_POSITION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FNC1_FIRST_POSITION, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FNC1_FIRST_POSITION, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode FNC1_SECOND_POSITION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FNC1_SECOND_POSITION, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FNC1_SECOND_POSITION, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mode HANZI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HANZI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HANZI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> characterCountBitsForVersions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterCountBitsForVersions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterCountBitsForVersions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _Bits_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Bits_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Bits_k__BackingField)) = value;
		}
	}

	public unsafe Names Name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_Names_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Names*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Name_Private_set_Void_Names_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int Bits
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Bits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Bits_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Mode()
	{
		Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "Mode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mode>.NativeClassPtr);
		NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "<Name>k__BackingField");
		NativeFieldInfoPtr_TERMINATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "TERMINATOR");
		NativeFieldInfoPtr_NUMERIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "NUMERIC");
		NativeFieldInfoPtr_ALPHANUMERIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "ALPHANUMERIC");
		NativeFieldInfoPtr_STRUCTURED_APPEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "STRUCTURED_APPEND");
		NativeFieldInfoPtr_BYTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "BYTE");
		NativeFieldInfoPtr_ECI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "ECI");
		NativeFieldInfoPtr_KANJI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "KANJI");
		NativeFieldInfoPtr_FNC1_FIRST_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "FNC1_FIRST_POSITION");
		NativeFieldInfoPtr_FNC1_SECOND_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "FNC1_SECOND_POSITION");
		NativeFieldInfoPtr_HANZI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "HANZI");
		NativeFieldInfoPtr_characterCountBitsForVersions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "characterCountBitsForVersions");
		NativeFieldInfoPtr__Bits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mode>.NativeClassPtr, "<Bits>k__BackingField");
		NativeMethodInfoPtr_get_Name_Public_get_Names_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_set_Name_Private_set_Void_Names_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int32_Int32_Names_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_forBits_Public_Static_Mode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_getCharacterCountBits_Public_Int32_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_get_Bits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_set_Bits_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mode>.NativeClassPtr, 100663622);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413781, XrefRangeEnd = 1413783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mode(Il2CppStructArray<int> characterCountBitsForVersions, int bits, Names name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mode>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterCountBitsForVersions);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(Names**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int32_Int32_Names_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413783, XrefRangeEnd = 1413787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mode forBits(int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_forBits_Public_Static_Mode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mode>(intPtr2) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1413789, RefRangeEnd = 1413798, XrefRangeStart = 1413787, XrefRangeEnd = 1413789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getCharacterCountBits(Version version)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)version);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCharacterCountBits_Public_Int32_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413798, XrefRangeEnd = 1413801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Mode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
