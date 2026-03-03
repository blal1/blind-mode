using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.Common;

public sealed class CharacterSetECI : ECI
{
	private static readonly IntPtr NativeFieldInfoPtr_VALUE_TO_ECI;

	private static readonly IntPtr NativeFieldInfoPtr_NAME_TO_ECI;

	private static readonly IntPtr NativeFieldInfoPtr_encodingName;

	private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_getCharacterSetECIByValue_Public_Static_CharacterSetECI_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getCharacterSetECIByName_Public_Static_CharacterSetECI_String_0;

	public unsafe static IDictionary<int, CharacterSetECI> VALUE_TO_ECI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VALUE_TO_ECI, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<int, CharacterSetECI>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VALUE_TO_ECI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<string, CharacterSetECI> NAME_TO_ECI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAME_TO_ECI, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, CharacterSetECI>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAME_TO_ECI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string encodingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encodingName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encodingName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string EncodingName
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EncodingName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static CharacterSetECI()
	{
		Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common", "CharacterSetECI");
		NativeFieldInfoPtr_VALUE_TO_ECI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, "VALUE_TO_ECI");
		NativeFieldInfoPtr_NAME_TO_ECI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, "NAME_TO_ECI");
		NativeFieldInfoPtr_encodingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, "encodingName");
		NativeMethodInfoPtr_get_EncodingName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_getCharacterSetECIByValue_Public_Static_CharacterSetECI_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr_getCharacterSetECIByName_Public_Static_CharacterSetECI_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr, 100664690);
	}

	[CallerCount(171)]
	[CachedScanResults(RefRangeStart = 351582, RefRangeEnd = 351753, XrefRangeStart = 351582, XrefRangeEnd = 351753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterSetECI(int value, string encodingName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSetECI>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encodingName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428852, XrefRangeEnd = 1428867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addCharacterSet(int value, string encodingName)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encodingName);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1428867, XrefRangeEnd = 1428886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addCharacterSet(int value, Il2CppStringArray encodingNames)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encodingNames);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addCharacterSet_Private_Static_Void_Int32_Il2CppStringArray_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1428894, RefRangeEnd = 1428896, XrefRangeStart = 1428886, XrefRangeEnd = 1428894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CharacterSetECI getCharacterSetECIByValue(int value)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCharacterSetECIByValue_Public_Static_CharacterSetECI_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterSetECI>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1428906, RefRangeEnd = 1428908, XrefRangeStart = 1428896, XrefRangeEnd = 1428906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CharacterSetECI getCharacterSetECIByName(string name)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCharacterSetECIByName_Public_Static_CharacterSetECI_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterSetECI>(intPtr2) : null;
	}

	public CharacterSetECI(IntPtr pointer)
		: base(pointer)
	{
	}
}
