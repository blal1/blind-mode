using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text;

[System.Serializable]
public sealed class EncoderFallbackException : ArgumentException
{
	private static readonly System.IntPtr NativeFieldInfoPtr__charUnknown;

	private static readonly System.IntPtr NativeFieldInfoPtr__charUnknownHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr__charUnknownLow;

	private static readonly System.IntPtr NativeFieldInfoPtr__index;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

	public unsafe char _charUnknown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknown);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknown)) = value;
		}
	}

	public unsafe char _charUnknownHigh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknownHigh);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknownHigh)) = value;
		}
	}

	public unsafe char _charUnknownLow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknownLow);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__charUnknownLow)) = value;
		}
	}

	public unsafe int _index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index)) = value;
		}
	}

	static EncoderFallbackException()
	{
		Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr);
		NativeFieldInfoPtr__charUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknown");
		NativeFieldInfoPtr__charUnknownHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknownHigh");
		NativeFieldInfoPtr__charUnknownLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknownLow");
		NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_index");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668612);
		NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668614);
		NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668615);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777011, XrefRangeEnd = 777014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EncoderFallbackException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777015, RefRangeEnd = 777016, XrefRangeStart = 777014, XrefRangeEnd = 777015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EncoderFallbackException(string message, char charUnknown, int index)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &charUnknown;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777023, RefRangeEnd = 777024, XrefRangeStart = 777016, XrefRangeEnd = 777023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &charUnknownHigh;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &charUnknownLow;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializationInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)streamingContext));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EncoderFallbackException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
