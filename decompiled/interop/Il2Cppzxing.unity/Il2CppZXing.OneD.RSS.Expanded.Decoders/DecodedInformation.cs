using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class DecodedInformation : DecodedObject
{
	private static readonly IntPtr NativeFieldInfoPtr_newString;

	private static readonly IntPtr NativeFieldInfoPtr_remainingValue;

	private static readonly IntPtr NativeFieldInfoPtr_remaining;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getNewString_Internal_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_isRemaining_Internal_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_getRemainingValue_Internal_Int32_0;

	public unsafe string newString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newString);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int remainingValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingValue)) = value;
		}
	}

	public unsafe bool remaining
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remaining);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remaining)) = value;
		}
	}

	static DecodedInformation()
	{
		Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "DecodedInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr);
		NativeFieldInfoPtr_newString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, "newString");
		NativeFieldInfoPtr_remainingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, "remainingValue");
		NativeFieldInfoPtr_remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, "remaining");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, 100664392);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, 100664393);
		NativeMethodInfoPtr_getNewString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, 100664394);
		NativeMethodInfoPtr_isRemaining_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_getRemainingValue_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr, 100664396);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1425227, RefRangeEnd = 1425230, XrefRangeStart = 1425225, XrefRangeEnd = 1425227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedInformation(int newPosition, string newString)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&newPosition);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newString);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425230, XrefRangeEnd = 1425234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedInformation(int newPosition, string newString, int remainingValue)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecodedInformation>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&newPosition);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newString);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &remainingValue;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getNewString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNewString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool isRemaining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isRemaining_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getRemainingValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRemainingValue_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecodedInformation(IntPtr pointer)
		: base(pointer)
	{
	}
}
