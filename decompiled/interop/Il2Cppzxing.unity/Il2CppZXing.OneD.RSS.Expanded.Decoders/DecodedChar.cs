using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class DecodedChar : DecodedObject
{
	private static readonly IntPtr NativeFieldInfoPtr_value;

	private static readonly IntPtr NativeFieldInfoPtr_FNC1;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Char_0;

	private static readonly IntPtr NativeMethodInfoPtr_getValue_Internal_Char_0;

	private static readonly IntPtr NativeMethodInfoPtr_isFNC1_Internal_Boolean_0;

	public unsafe char value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = value;
		}
	}

	public unsafe static char FNC1
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FNC1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FNC1, (void*)(&value));
		}
	}

	static DecodedChar()
	{
		Il2CppClassPointerStore<DecodedChar>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "DecodedChar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr);
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr, "value");
		NativeFieldInfoPtr_FNC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr, "FNC1");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr, 100664388);
		NativeMethodInfoPtr_getValue_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr, 100664389);
		NativeMethodInfoPtr_isFNC1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr, 100664390);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425220, XrefRangeEnd = 1425221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedChar(int newPosition, char value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecodedChar>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&newPosition);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe char getValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getValue_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425221, XrefRangeEnd = 1425225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isFNC1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFNC1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecodedChar(IntPtr pointer)
		: base(pointer)
	{
	}
}
