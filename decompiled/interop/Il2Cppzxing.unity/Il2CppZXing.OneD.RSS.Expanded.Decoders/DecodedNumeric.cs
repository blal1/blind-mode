using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class DecodedNumeric : DecodedObject
{
	private static readonly IntPtr NativeFieldInfoPtr_firstDigit;

	private static readonly IntPtr NativeFieldInfoPtr_secondDigit;

	private static readonly IntPtr NativeFieldInfoPtr_FNC1;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getFirstDigit_Internal_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getSecondDigit_Internal_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_isFirstDigitFNC1_Internal_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_isSecondDigitFNC1_Internal_Boolean_0;

	public unsafe int firstDigit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDigit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDigit)) = value;
		}
	}

	public unsafe int secondDigit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondDigit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondDigit)) = value;
		}
	}

	public unsafe static int FNC1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FNC1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FNC1, (void*)(&value));
		}
	}

	static DecodedNumeric()
	{
		Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "DecodedNumeric");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr);
		NativeFieldInfoPtr_firstDigit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, "firstDigit");
		NativeFieldInfoPtr_secondDigit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, "secondDigit");
		NativeFieldInfoPtr_FNC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, "FNC1");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_getFirstDigit_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, 100664398);
		NativeMethodInfoPtr_getSecondDigit_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_isFirstDigitFNC1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_isSecondDigitFNC1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr, 100664401);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425235, RefRangeEnd = 1425236, XrefRangeStart = 1425234, XrefRangeEnd = 1425235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedNumeric(int newPosition, int firstDigit, int secondDigit)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecodedNumeric>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&newPosition);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &firstDigit;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &secondDigit;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getFirstDigit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFirstDigit_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getSecondDigit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSecondDigit_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425236, XrefRangeEnd = 1425240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isFirstDigitFNC1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFirstDigitFNC1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425244, RefRangeEnd = 1425245, XrefRangeStart = 1425240, XrefRangeEnd = 1425244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isSecondDigitFNC1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSecondDigitFNC1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecodedNumeric(IntPtr pointer)
		: base(pointer)
	{
	}
}
